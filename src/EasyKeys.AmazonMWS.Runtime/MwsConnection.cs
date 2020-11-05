/*******************************************************************************
 * Copyright 2009-2012 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License");
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Runtime Client Library
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace EasyKeys.AmazonMWS.Runtime
{
    public class MwsConnection : ICloneable
    {
        private readonly object _lockThis = new object();

        private string _applicationName;
        private string _applicationVersion;
        private string _libraryVersion;
        private string _userAgent;
        private Dictionary<string, string> _headers;

        private string _awsAccessKeyId;
        private string _awsSecretKeyId;
        private string _signatureVersion;
        private string _signatureMethod;

        private int _connectionTimeout;
        private int _maxErrorRetry;

        private Uri _endpoint;

        private string _proxyHost;
        private int _proxyPort;
        private string _proxyUsername;
        private string _proxyPassword;

        private volatile bool _frozen;
        private Dictionary<string, ServiceEndpoint> _cachedServiceMap;

        public MwsConnection()
        {
            _cachedServiceMap = new Dictionary<string, ServiceEndpoint>();
            _headers = new Dictionary<string, string>();

            _frozen = false;
            _signatureVersion = "2";
            _signatureMethod = "HmacSHA256";
            _connectionTimeout = 50000;
            _maxErrorRetry = 3;
            _libraryVersion = "1.0.0";
        }

        public MwsConnection(Uri endpoint, string applicationName, string applicationVersion, string awsAccessKeyId, string awsSecretKeyId) : this()
        {
            _endpoint = endpoint;
            _applicationName = applicationName;
            _applicationVersion = applicationVersion;
            _awsAccessKeyId = awsAccessKeyId;
            _awsSecretKeyId = awsSecretKeyId;
        }

        /// <summary>
        /// Creates a new MwsCall.
        /// </summary>
        /// <param name="servicePath"></param>
        /// <param name="operationName"></param>
        /// <returns>A new request.</returns>
        public IMwsCall NewCall(string servicePath, string operationName)
        {
            if (!_frozen)
            {
                Freeze();
            }

            var sep = GetServiceEndpoint(servicePath);
            return new MwsAQCall(this, sep, operationName);
        }

        /// <summary>
        /// Creates a MwsCall and sends the request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public T Call<T>(
            IMwsRequestType<T> type,
            IMwsObject requestData) where T : IMwsObject
        {
            try
            {
                var servicePath = type.ServicePath;
                var operationName = type.OperationName;
                var mc = NewCall(servicePath, operationName);
                requestData.WriteFragmentTo(mc);
                var responseReader = mc.Invoke();
                var rhmd = mc.GetResponseMetadataHeader();
                var response = MwsUtil.NewInstance<T>();
                type.SetResponseHeaderMetadata(response, rhmd);
                response.ReadFragmentFrom(responseReader);
                return response;
            }
            catch (Exception e)
            {
                throw type.WrapException(e);
            }
        }

        /// <summary>
        /// Clones the connection and resets the state as if it was never used.
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            var conn = (MwsConnection)MemberwiseClone();
            conn._cachedServiceMap = new Dictionary<string, ServiceEndpoint>();
            conn._frozen = false;
            return conn;
        }

        /// <summary>
        /// Construct a user agent header - synchronized.
        /// </summary>
        /// <param name="applicationName">Escaped application name.</param>
        /// <param name="applicationVersion">Escaped application version.</param>
        /// <param name="programmingLanguage">Escaped programming language.</param>
        /// <param name="additionalNameValuePairs">Raw attribute name,value pair.</param>
        public void SetUserAgent(string applicationName, string applicationVersion, string programmingLanguage, string[] additionalNameValuePairs)
        {
            lock (_lockThis)
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException("applicationName", "Value cannot be null.");
                }

                if (applicationVersion == null)
                {
                    throw new ArgumentNullException("applicationVersion", "Value cannot be null.");
                }

                if (programmingLanguage == null)
                {
                    throw new ArgumentNullException("programmingLanguage", "Value cannot be null.");
                }

                if (additionalNameValuePairs.Length % 2 != 0)
                {
                    throw new ArgumentException("additionalNameValuePairs", "Every name must have a corresponding value.");
                }

                var sb = new StringBuilder();
                sb.Append(applicationName);
                sb.Append("/");
                sb.Append(applicationVersion);
                sb.Append(" (");
                sb.Append("Language=");
                sb.Append(programmingLanguage);
                var i = 0;
                while (i < additionalNameValuePairs.Length)
                {
                    var name = additionalNameValuePairs[i];
                    var value = additionalNameValuePairs[++i];
                    sb.Append("; ");
                    sb.Append(MwsUtil.EscapeAttributeName(name));
                    sb.Append("=");
                    sb.Append(MwsUtil.EscapeAttributeValue(value));
                    i++;
                }

                sb.Append(")");
                _userAgent = sb.ToString();
            }
        }

        public string ApplicationName
        {
            get => _applicationName;

            set
            {
                CheckUpdatable();
                _applicationName = value;
            }
        }

        public string ApplicationVersion
        {
            get => _applicationVersion;

            set
            {
                CheckUpdatable();
                _applicationVersion = value;
            }
        }

        /// <summary>
        /// Gets or sets the client library version, defaults to 1.0.0.
        /// </summary>
        public string LibraryVersion
        {
            get => _libraryVersion;

            set
            {
                CheckUpdatable();
                _libraryVersion = value;
            }
        }

        public string UserAgent
        {
            get => _userAgent;

            set
            {
                CheckUpdatable();
                _userAgent = value;
            }
        }

        public string AwsAccessKeyId
        {
            get => _awsAccessKeyId;

            set
            {
                CheckUpdatable();
                _awsAccessKeyId = value;
            }
        }

        public string AwsSecretKeyId
        {
            get => _awsSecretKeyId;

            set
            {
                CheckUpdatable();
                _awsSecretKeyId = value;
            }
        }

        /// <summary>
        /// Get or set max number of retries - default is 3.
        /// </summary>
        /// <returns></returns>
        public int MaxErrorRetry
        {
            get => _maxErrorRetry;

            set
            {
                CheckUpdatable();
                _maxErrorRetry = value;
            }
        }

        /// <summary>
        /// Get or set MWS endpoint URI.
        /// </summary>
        public Uri Endpoint
        {
            get => _endpoint;

            set
            {
                CheckUpdatable();
                _endpoint = value;
            }
        }

        public ServiceEndpoint GetServiceEndpoint(string servicePath)
        {
            lock (_cachedServiceMap)
            {
                if (!_cachedServiceMap.ContainsKey(servicePath))
                {
                    var sep = new ServiceEndpoint(Endpoint, servicePath);
                    _cachedServiceMap.Add(servicePath, sep);
                }

                return _cachedServiceMap[servicePath];
            }
        }

        /// <summary>
        /// Get or set signature version - defaults to 2.
        /// </summary>
        /// <returns></returns>
        public string SignatureVersion
        {
            get => _signatureVersion;

            set
            {
                CheckUpdatable();
                _signatureVersion = value;
            }
        }

        /// <summary>
        /// Get or set signature method - defaults to HmacSHA256.
        /// </summary>
        /// <returns></returns>
        public string SignatureMethod
        {
            get => _signatureMethod;

            set
            {
                CheckUpdatable();
                _signatureMethod = value;
            }
        }

        /// <summary>
        /// Get or set connection timeout, defaults to 50000.
        /// </summary>
        /// <returns></returns>
        public int ConnectionTimeout
        {
            get => _connectionTimeout;

            set
            {
                CheckUpdatable();
                _connectionTimeout = value;
            }
        }

        public string ProxyHost
        {
            get => _proxyHost;

            set
            {
                CheckUpdatable();
                _proxyHost = value;
            }
        }

        public int ProxyPort
        {
            get => _proxyPort;

            set
            {
                CheckUpdatable();
                _proxyPort = value;
            }
        }

        public string ProxyUsername
        {
            get => _proxyUsername;

            set
            {
                CheckUpdatable();
                _proxyUsername = value;
            }
        }

        public string ProxyPassword
        {
            get => _proxyPassword;

            set
            {
                CheckUpdatable();
                _proxyPassword = value;
            }
        }

        /// <summary>
        /// Sets the value of a request header to be included on every request.
        /// </summary>
        /// <param name="name">the name of the header to set.</param>
        /// <param name="value">value to send with header.</param>
        public void IncludeRequestHeader(string name, string value)
        {
            CheckUpdatable();
            _headers[name] = value;
        }

        /// <summary>
        /// Gets the currently set value of a request header.
        /// </summary>
        /// <param name="name">the name of the header to get.</param>
        /// <returns>value of specified header, or null if not defined.</returns>
        public string GetRequestHeader(string name)
        {
            if (_headers.ContainsKey(name))
            {
                return _headers[name];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Immutable service and version URI for an endpoint.
        /// </summary>
        public class ServiceEndpoint
        {
            /** The service name. */
            public readonly string service;

            /** The service and version name as service/version. */
            public readonly string servicePath;

            /** The combined uri of the connection, service name, and version. */
            public readonly Uri URI;

            /** The service version. */
            public readonly string version;

            /// <summary>
            /// Initializes a new instance of the <see cref="ServiceEndpoint"/> class.
            /// Creates a new URI.
            /// </summary>
            /// <param name="baseUri"></param>
            /// <param name="servicePath"></param>
            public ServiceEndpoint(Uri baseUri, string servicePath)
            {
                if (servicePath.Length > 0)
                {
                    this.servicePath = servicePath;
                    var j = servicePath.LastIndexOf('/');
                    service = servicePath.Substring(0, j);
                    version = servicePath.Substring(j + 1);
                }

                URI = new Uri(baseUri, "/" + servicePath);
            }
        }

        internal HttpWebRequest GetHttpClient(Uri uri)
        {
            if (_frozen)
            {
                var request = WebRequest.Create(uri) as HttpWebRequest;
                if (ProxyHost != null && ProxyPort != 0)
                {
                    request.Proxy = new WebProxy(ProxyHost, ProxyPort);
                    request.Proxy.Credentials = new NetworkCredential(ProxyUsername, ProxyPassword);
                }

                request.UserAgent = UserAgent;
                request.Method = "POST";
                request.Timeout = ConnectionTimeout;
                request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
                foreach (var header in _headers)
                {
                    request.Headers[header.Key] = header.Value;
                }

                return request;
            }
            else
            {
                throw new InvalidOperationException("Must freeze properties before making HTTP requests");
            }
        }

        private void CheckUpdatable()
        {
            if (_frozen)
            {
                throw new InvalidOperationException("Cannot change MwsConnection properties once connected");
            }
        }

        private void SetDefaultUserAgent()
        {
            SetUserAgent(
                MwsUtil.EscapeAppName(ApplicationName),
                MwsUtil.EscapeAppVersion(ApplicationVersion),
                MwsUtil.EscapeAttributeValue("C#"),
                new string[]
                {
                    "CLI", Environment.Version.ToString(),
                    "Platform", Environment.OSVersion.Platform.ToString() + "/" + Environment.OSVersion.Version,
                    "MWSClientVersion", LibraryVersion
                });
        }

        private void Freeze()
        {
            lock (_lockThis)
            {
                if (UserAgent == null)
                {
                    SetDefaultUserAgent();
                }

                _headers = new Dictionary<string, string>(_headers);

                _frozen = true;
            }
        }
    }
}

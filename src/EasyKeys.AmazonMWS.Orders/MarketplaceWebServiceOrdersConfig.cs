/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License");
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Orders
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using System;

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    /// <summary>
    /// Configuration for a connection.
    /// </summary>
    public class MarketplaceWebServiceOrdersConfig
    {
        private const string DEFAULT_SERVICE_PATH = "Orders/2013-09-01";
        private const string SERVICE_VERSION = "2013-09-01";
        private MwsConnection _cc = new MwsConnection();

        internal string ServicePath { get; private set; }

        /// <summary>
        /// Get a clone of the configured connection.
        /// </summary>
        /// <returns>A clone of the configured connection.</returns>
        internal MwsConnection CopyConnection()
        {
            return (MwsConnection)_cc.Clone();
        }

        /// <summary>
        /// Gets the service version this client library is compatible with.
        /// </summary>
        public string ServiceVersion => SERVICE_VERSION;

        /// <summary>
        /// Gets and sets of the SignatureMethod used to authenticate with MWS.
        /// </summary>
        public string SignatureMethod
        {
            get => _cc.SignatureMethod;
            set => _cc.SignatureMethod = value;
        }

        /// <summary>
        /// Sets the SignatureMethod used to authenticate with MWS.
        /// </summary>
        /// <param name="signatureMethod">Signature method to use (ex: HmacSHA256).</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithSignatureMethod(string signatureMethod)
        {
            SignatureMethod = signatureMethod;
            return this;
        }

        /// <summary>
        /// Checks if SignatureMethod is set.
        /// </summary>
        /// <returns>true if SignatureMethod is set.</returns>
        public bool IsSetSignatureMethod()
        {
            return SignatureMethod != null;
        }

        /// <summary>
        /// Gets and sets of the SignatureVersion used to authenticate with MWS.
        /// </summary>
        public string SignatureVersion
        {
            get => _cc.SignatureVersion;
            set => _cc.SignatureVersion = value;
        }

        /// <summary>
        /// Sets the SignatureVersion used to authenticate with MWS.
        /// </summary>
        /// <param name="signatureVersion"></param>
        /// <param name="signatureMethod">Signature version to use (ex: 2).</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithSignatureVersion(string signatureVersion)
        {
            SignatureVersion = signatureVersion;
            return this;
        }

        /// <summary>
        /// Checks if SignatureVersion is set.
        /// </summary>
        /// <returns>true if SignatureVersion is set.</returns>
        public bool IsSetSignatureVersion()
        {
            return SignatureVersion != null;
        }

        /// <summary>
        /// Gets the UserAgent.
        /// </summary>
        public string UserAgent => _cc.UserAgent;

        /// <summary>
        /// Sets the UserAgent property.
        /// </summary>
        /// <param name="userAgent">UserAgent property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithUserAgent(String userAgent)
        {
            _cc.UserAgent = userAgent;
            return this;
        }

        public void SetUserAgentHeader(
            string applicationName,
            string applicationVersion,
            string programmingLanguage,
            params string[] additionalNameValuePairs)
        {
            _cc.SetUserAgent(applicationName, applicationVersion, programmingLanguage, additionalNameValuePairs);
        }

        /// <summary>
        /// Sets the UserAgent.
        /// </summary>
        /// <param name="applicationName">Your application's name, e.g. "MyMWSApp".</param>
        /// <param name="applicationVersion">Your application's version, e.g. "1.0".</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithUserAgent(string applicationName, string applicationVersion)
        {
            SetUserAgent(applicationName, applicationVersion);
            return this;
        }

        public void SetUserAgent(string applicationName, string applicationVersion)
        {
            _cc.ApplicationName = applicationName;
            _cc.ApplicationVersion = applicationVersion;
        }

        /// <summary>
        /// Checks if UserAgent is set.
        /// </summary>
        /// <returns>true if UserAgent is set.</returns>
        public bool IsSetUserAgent()
        {
            return UserAgent != null;
        }

        /// <summary>
        /// Gets and sets of the URL to base MWS calls on
        /// May include the path to make MWS calls to. Defaults to Orders/2013-09-01.
        /// </summary>
        public string ServiceURL
        {
            get => new Uri(_cc.Endpoint, ServicePath).ToString();

            set
            {
                try
                {
                    var fullUri = new Uri(value);
                    _cc.Endpoint = new Uri(fullUri.Scheme + "://" + fullUri.Authority);

                    // Strip slashes
                    var path = fullUri.PathAndQuery;
                    if (path != null)
                    {
                        path = path.Trim(new[] { '/' });
                    }

                    if (String.IsNullOrEmpty(path))
                    {
                        ServicePath = DEFAULT_SERVICE_PATH;
                    }
                    else
                    {
                        ServicePath = path;
                    }
                }
                catch (Exception e)
                {
                    throw MwsUtil.Wrap(e);
                }
            }
        }

        /// <summary>
        /// Sets the ServiceURL property.
        /// </summary>
        /// <param name="serviceURL">ServiceURL property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithServiceURL(string serviceURL)
        {
            ServiceURL = serviceURL;
            return this;
        }

        /// <summary>
        /// Checks if Service URL is set.
        /// </summary>
        /// <returns>true if Service URL is set.</returns>
        public bool IsSetServiceURL()
        {
            return _cc.Endpoint != null;
        }

        /// <summary>
        /// Gets and sets the host to use as a proxy server.
        /// </summary>
        public string ProxyHost
        {
            get => _cc.ProxyHost;
            set => _cc.ProxyHost = value;
        }

        /// <summary>
        /// Sets the host to use as a proxy server.
        /// </summary>
        /// <param name="proxyHost">proxy host.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithProxyHost(string proxyHost)
        {
            ProxyHost = proxyHost;
            return this;
        }

        /// <summary>
        /// Checks if proxy host is set.
        /// </summary>
        /// <returns>true if proxy host is set.</returns>
        public bool IsSetProxyHost()
        {
            return ProxyHost != null;
        }

        /// <summary>
        /// Gets and sets the port on your proxy server to use.
        /// </summary>
        public int ProxyPort
        {
            get => _cc.ProxyPort;
            set => _cc.ProxyPort = value;
        }

        /// <summary>
        /// Sets the port on your proxy server to use.
        /// </summary>
        /// <param name="proxyPort">port number.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithProxyPort(int proxyPort)
        {
            ProxyPort = proxyPort;
            return this;
        }

        /// <summary>
        /// Checks if proxy port is set.
        /// </summary>
        /// <returns>true if proxy port is set.</returns>
        public bool IsSetProxyPort()
        {
            return _cc.ProxyPort != -1;
        }

        /// <summary>
        /// Gets and sets the username to use with your proxy server.
        /// </summary>
        public string ProxyUsername
        {
            get => _cc.ProxyUsername;
            set => _cc.ProxyUsername = value;
        }

        /// <summary>
        /// Sets the username to use with your proxy server.
        /// </summary>
        /// <param name="proxyUsername">proxy username.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithProxyUsername(string proxyUsername)
        {
            ProxyUsername = proxyUsername;
            return this;
        }

        /// <summary>
        /// Checks if proxy username is set.
        /// </summary>
        /// <returns>true if proxy username is set.</returns>
        public bool IsSetProxyUsername()
        {
            return ProxyUsername != null;
        }

        /// <summary>
        /// Gets and sets the password to use with your proxy server.
        /// </summary>
        public string ProxyPassword
        {
            get => _cc.ProxyPassword;
            set => _cc.ProxyPassword = value;
        }

        /// <summary>
        /// Sets the password to use with your proxy server.
        /// </summary>
        /// <param name="proxyPassword">proxy password.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithProxyPassword(string proxyPassword)
        {
            ProxyPassword = proxyPassword;
            return this;
        }

        /// <summary>
        /// Checks if proxy password is set.
        /// </summary>
        /// <returns>true if proxy password is set.</returns>
        public bool IsSetProxyPassword()
        {
            return ProxyPassword != null;
        }

        /// <summary>
        /// Gets and sets the maximum number of times to retry failed requests.
        /// </summary>
        public int MaxErrorRetry
        {
            get => _cc.MaxErrorRetry;
            set => _cc.MaxErrorRetry = value;
        }

        /// <summary>
        /// Sets the maximum number of times to retry failed requests.
        /// </summary>
        /// <param name="maxErrorRetry">times to retry.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceOrdersConfig WithMaxErrorRetry(int maxErrorRetry)
        {
            _cc.MaxErrorRetry = maxErrorRetry;
            return this;
        }

        /// <summary>
        /// Checks if MaxErrorRetry is set.
        /// </summary>
        /// <returns>true if MaxErrorRetry is set.</returns>
        public bool IsSetMaxErrorRetry()
        {
            return _cc.MaxErrorRetry != -1;
        }

        /// <summary>
        /// Sets the value of a request header to be included on every request.
        /// </summary>
        /// <param name="name">the name of the header to set.</param>
        /// <param name="value">value to send with header.</param>
        public void IncludeRequestHeader(string name, string value)
        {
            _cc.IncludeRequestHeader(name, value);
        }

        /// <summary>
        /// Sets the value of a request header to be included on every request.
        /// </summary>
        /// <param name="name">the name of the header to set.</param>
        /// <param name="value">value to send with header.</param>
        /// <returns>the current config object.</returns>
        public MarketplaceWebServiceOrdersConfig WithRequestHeader(string name, string value)
        {
            _cc.IncludeRequestHeader(name, value);
            return this;
        }

        /// <summary>
        /// Gets the currently set value of a request header.
        /// </summary>
        /// <param name="name">name the name of the header to get.</param>
        /// <returns>value of specified header, or null if not defined.</returns>
        public string GetRequestHeader(string name)
        {
            return _cc.GetRequestHeader(name);
        }

        /// <summary>
        /// Checks if a request header is set.
        /// </summary>
        /// <param name="name">the name of the header to check.</param>
        /// <returns>true, if the header is set.</returns>
        public bool IsSetRequestHeader(string name)
        {
            return _cc.GetRequestHeader(name) != null;
        }
    }
}

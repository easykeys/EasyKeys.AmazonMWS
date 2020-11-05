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
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;

namespace EasyKeys.AmazonMWS.Runtime
{
    /// <summary>
    /// AWS query call implementation.
    /// </summary>
    public class MwsAQCall : IMwsCall
    {
        public HttpWebRequest request;

        private readonly MwsConnection _connection;
        private readonly IDictionary<string, string> _parameters = new SortedDictionary<string, string>(StringComparer.Ordinal);
        private readonly MwsConnection.ServiceEndpoint _serviceEndPoint;

        private readonly string _operationName;
        private MwsResponseHeaderMetadata _ResponseHeaderMetadata;

        public MwsAQCall(MwsConnection connection, MwsConnection.ServiceEndpoint serviceEndpoint, string operationName)
        {
            _connection = connection;
            _serviceEndPoint = serviceEndpoint;
            _operationName = operationName;
        }

        public MwsResponseHeaderMetadata GetResponseMetadataHeader()
        {
            return _ResponseHeaderMetadata;
        }

        /// <summary>
        /// Creates a request and invokes it.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MwsException">Exceptions from invoking the request.</exception>
        public IMwsReader Invoke()
        {
            string responseBody;
            string message;
            var statusCode = default(HttpStatusCode);
            /* Add required request parameters */
            AddRequiredParameters();
            var queryString = GetParametersAsString(_parameters);
            var retries = 0;
            do
            {
                /* Submit the request and read response body */
                try
                {
                    request = _connection.GetHttpClient(_serviceEndPoint.URI);
                    var requestData = new UTF8Encoding().GetBytes(queryString);
                    request.ContentLength = requestData.Length;
                    using (var requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(requestData, 0, requestData.Length);
                    }

                    using (var httpResponse = request.GetResponse() as HttpWebResponse)
                    {
                        statusCode = httpResponse.StatusCode;
                        message = httpResponse.StatusDescription;
                        _ResponseHeaderMetadata = GetResponseHeaderMetadata(httpResponse);
                        var reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
                        responseBody = reader.ReadToEnd();
                    }

                    if (statusCode == HttpStatusCode.OK)
                    {
                        return new MwsXmlReader(responseBody);
                    }

                    var e = new MwsException((int)statusCode, message, null, null, responseBody, _ResponseHeaderMetadata);

                    if (statusCode == HttpStatusCode.InternalServerError)
                    {
                        if (PauseIfRetryNeeded(retries++))
                        {
                            continue;
                        }
                    }

                    throw e;
                }

                /* Web exception is thrown on unsuccessful responses */
                catch (WebException we)
                {
                    using (var httpErrorResponse = (HttpWebResponse)we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            throw new MwsException(we);
                        }

                        statusCode = httpErrorResponse.StatusCode;
                        using (var reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }

                    // retry logic
                    if (PauseIfRetryNeeded(retries++))
                    {
                        continue;
                    }

                    throw new MwsException((int)statusCode, null, null, null, responseBody, null);
                }

                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception e)
                {
                    throw new MwsException(e);
                }
            }
            while (true);
        }

        /// <summary>
        /// Extracts and assigns the response header metadata.
        /// </summary>
        /// <param name="httpResponse"></param>
        /// <returns></returns>
        private static MwsResponseHeaderMetadata GetResponseHeaderMetadata(HttpWebResponse httpResponse)
        {
            var requestId = httpResponse.GetResponseHeader("x-mws-request-id");
            var timestamp = httpResponse.GetResponseHeader("x-mws-timestamp");
            var contextStr = httpResponse.GetResponseHeader("x-mws-response-context");
            var context = new List<string>(contextStr.Split(','));

            double? quotaMax;
            try
            {
                var quotaMaxStr = httpResponse.GetResponseHeader("x-mws-quota-max");
                quotaMax = Double.Parse(quotaMaxStr);
            }
            catch (Exception)
            {
                quotaMax = null;
            }

            double? quotaRemaining;
            try
            {
                var quotaRemainingStr = httpResponse.GetResponseHeader("x-mws-quota-remaining");
                quotaRemaining = Double.Parse(quotaRemainingStr);
            }
            catch (Exception)
            {
                quotaRemaining = null;
            }

            DateTime? quotaResetsAt;
            try
            {
                var quotaResetsAtStr = httpResponse.GetResponseHeader("x-mws-quota-resetsOn");
                quotaResetsAt = MwsUtil.ParseTimestamp(quotaResetsAtStr);
            }
            catch (Exception)
            {
                quotaResetsAt = null;
            }

            return new MwsResponseHeaderMetadata(requestId, context, timestamp, quotaMax, quotaRemaining, quotaResetsAt);
        }

        /// <summary>
        /// Pauses for a while before retry.
        /// <para>The amount of pause depends on the index of retry, the higher number of retry the longer the pause.</para>
        /// </summary>
        /// <param name="retries"></param>
        /// <returns></returns>
        private bool PauseIfRetryNeeded(int retries)
        {
            if (retries == _connection.MaxErrorRetry)
            {
                return false;
            }

            var delay = (int)(Math.Pow(4, retries) * 125);
            try
            {
                Thread.Sleep(delay);
            }
            catch (Exception e)
            {
                throw new SystemException("Error checking if retry is needed", e);
            }

            return true;
        }

        /// <summary>
        /// Constructs the parameters as string.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private string GetParametersAsString(IDictionary<string, string> parameters)
        {
            var data = new StringBuilder();
            foreach (var key in (IEnumerable<string>)parameters.Keys)
            {
                var value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(MwsUtil.UrlEncode(value, false));
                    data.Append('&');
                }
            }

            var result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /// <summary>
        /// Add authentication related and version parameters.
        /// </summary>
        private void AddRequiredParameters()
        {
            _parameters.Add("AWSAccessKeyId", _connection.AwsAccessKeyId);
            _parameters.Add("Action", _operationName);
            _parameters.Add("Timestamp", MwsUtil.GetFormattedTimestamp());
            _parameters.Add("Version", _serviceEndPoint.version);
            var signature = MwsUtil.SignParameters(_serviceEndPoint.URI, _connection.SignatureVersion, _connection.SignatureMethod, _parameters, _connection.AwsSecretKeyId);
            _parameters.Add("Signature", signature);
        }

        private void PutValue(object value)
        {
            if (value == null)
            {
                return;
            }

            if (value is IMwsObject)
            {
                _parameterPrefix.Append('.');
                (value as IMwsObject).WriteFragmentTo(this);
                return;
            }

            var name = _parameterPrefix.ToString();
            if (value is DateTime)
            {
                _parameters.Add(name, MwsUtil.GetFormattedTimestamp((DateTime)value));
                return;
            }

            var valueStr = value.ToString();
            if (valueStr == null || valueStr.Length == 0)
            {
                return;
            }

            if (value is bool)
            {
                valueStr = valueStr.ToLower();
            }

            _parameters.Add(name, valueStr);
        }

        /** The parameter prefix */
        private readonly StringBuilder _parameterPrefix = new StringBuilder();

        public void Write(string name, object value)
        {
            var holdParameterPrefixLen = _parameterPrefix.Length;
            _parameterPrefix.Append(name);
            PutValue(value);
            _parameterPrefix.Length = holdParameterPrefixLen;
        }

        public void Write(string xmlNamespace, string name, IMwsObject value)
        {
            if (value != null)
            {
                value.WriteFragmentTo(this);
            }
        }

        public void WriteAttribute(string name, object value)
        {
            Write(name, value);
        }

        public void WriteList<T>(string name, string memberName, ICollection<T> list)
        {
            if (list == null)
            {
                return;
            }

            if (name == null && memberName == null)
            {
                throw new ArgumentNullException("Both name and memberName cannot be null.");
            }

            var holdParameterPrefixLen = _parameterPrefix.Length;
            if (name != null)
            {
                _parameterPrefix.Append(name);
            }

            if (name != null && memberName != null)
            {
                _parameterPrefix.Append('.');
            }

            if (memberName != null)
            {
                _parameterPrefix.Append(memberName);
            }

            _parameterPrefix.Append('.');
            var dotLen = _parameterPrefix.Length;
            var i = 1;
            foreach (Object v in list)
            {
                _parameterPrefix.Length = dotLen;
                _parameterPrefix.Append(i);
                PutValue(v);
                i++;
            }

            _parameterPrefix.Length = holdParameterPrefixLen;
        }

        public void WriteList<T>(string name, ICollection<T> list)
        {
            WriteList<T>(null, name, list);
        }

        public void WriteAny(ICollection<XmlElement> elements)
        {
            throw new NotSupportedException("WriteAny not supported");
        }

        public void WriteValue(object value)
        {
            throw new NotSupportedException("WriteValue not supported");
        }

        public void BeginObject(string name)
        {
            throw new NotSupportedException("Complex object writing not supported");
        }

        public void Close()
        {
            // nothing to do
        }

        public void EndObject(string name)
        {
            throw new NotSupportedException("Complex object writing not supported");
        }
    }
}

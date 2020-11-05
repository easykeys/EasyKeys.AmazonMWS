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
using System.Net;

namespace EasyKeys.AmazonMWS.Runtime
{
    /// <summary>
    /// Wrapped exception.
    /// </summary>
    public class MwsException : SystemException
    {
        private int _statusCode;
        private string _message;
        private string _detail;
        private string _errorCode;
        private string _errorType;
        private string _xml;
        private MwsResponseHeaderMetadata _rhmd;

        public MwsException(Exception cause) : this(0, null, cause)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MwsException"/> class.
        /// Initializes exception with information available from the service.
        /// </summary>
        /// <param name="statusCode">HTTP status code for error response (as an int).</param>
        /// <param name="message">Error message from HTTP header.</param>
        /// <param name="errorCode">Error code from response XML.</param>
        /// <param name="errorType">Error type from response XML.</param>
        /// <param name="xml">Compete XML found in response.</param>
        /// <param name="rhmd">Response header information.</param>
        public MwsException(int statusCode, string message, string errorCode, string errorType, string xml, MwsResponseHeaderMetadata rhmd)
            : this(statusCode, message, errorCode, errorType, xml, rhmd, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MwsException"/> class.
        /// Initializes exception with information available from the service plus from an exception
        /// Needed for backwards compatibility.
        /// </summary>
        /// <param name="statusCode">HTTP status code for error response (as an int).</param>
        /// <param name="message">Error message from HTTP header.</param>
        /// <param name="errorCode">Error code from response XML.</param>
        /// <param name="errorType">Error type from response XML.</param>
        /// <param name="xml">Compete XML found in response.</param>
        /// <param name="rhmd">Response header information.</param>
        /// <param name="cause">Wrapped exception.</param>
        public MwsException(int statusCode, string message, string errorCode, string errorType, string xml, MwsResponseHeaderMetadata rhmd, Exception cause)
            : base()
        {
            _statusCode = statusCode;
            _rhmd = rhmd;
            _xml = xml;
            _errorType = errorType;
            _errorCode = errorCode;
            _message = message;

            if (xml != null)
            {
                PopulateFromXML(xml);
            }

            if (cause is MwsException)
            {
                PopulateFromMWSException((MwsException)cause);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MwsException"/> class.
        /// Initialize and set cause from another exception.
        /// <para>
        /// If cause is an MwsException, copies exception's attributes to this
        /// one, overwriting the statusCode and message parameters that were passed in.
        /// </para>
        /// </summary>
        /// <param name="statusCode">HTTP status code for error response.</param>
        /// <param name="message">Error message from HTTP header.</param>
        /// <param name="cause">Inner exception.</param>
        ////
        public MwsException(int statusCode, string message, Exception cause)
            : base(message, cause)
        {
            _statusCode = statusCode;
            _message = message;

            if (cause is MwsException)
            {
                PopulateFromMWSException((MwsException)cause);
            }
        }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        public override string Message => _message;

        /// <summary>
        /// Specific details about the error.
        /// </summary>
        public string Detail => _detail;

        /// <summary>
        /// Consistent error code.
        /// </summary>
        public string ErrorCode => _errorCode;

        /// <summary>
        /// Type of error, if available.
        /// </summary>
        public string ErrorType => _errorType;

        /// <summary>
        /// ID of request returned by the service, if available.
        /// </summary>
        public string RequestId => ResponseHeaderMetadata != null ? ResponseHeaderMetadata.RequestId : null;

        /// <summary>
        /// HTTP Status code returned by the service, if available.
        /// Set to HttpStatusCode.NotAcceptable if no status code available.
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get
            {
                try
                {
                    return (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), _statusCode.ToString());
                }
                catch (Exception)
                {
                    return HttpStatusCode.NotAcceptable;
                }
            }
        }

        /// <summary>
        /// Raw XML returned by the service, if available.
        /// </summary>
        public string XML => _xml;

        public virtual MwsResponseHeaderMetadata ResponseHeaderMetadata => _rhmd;

        private void PopulateFromMWSException(MwsException e)
        {
            if (e.StatusCode != null)
            {
                _statusCode = (int)e.StatusCode;
            }

            if (e.Message != null)
            {
                _message = e.Message;
            }

            if (e._errorCode != null)
            {
                _errorCode = e.ErrorCode;
            }

            if (e._errorType != null)
            {
                _errorType = e.ErrorType;
            }

            if (e._detail != null)
            {
                _detail = e.Detail;
            }

            if (e._xml != null)
            {
                _xml = e.XML;
            }

            if (e.ResponseHeaderMetadata != null)
            {
                _rhmd = e.ResponseHeaderMetadata;
            }
        }

        private void PopulateFromXML(string xml)
        {
            try
            {
                var r = new MwsXmlReader(xml);
                var parsed = r.Read<XmlMwsException>("Error");
                if (parsed.ErrorType != null)
                {
                    _errorType = parsed.ErrorType;
                }

                if (parsed.ErrorCode != null)
                {
                    _errorCode = parsed.ErrorCode;
                }

                if (parsed.Message != null)
                {
                    _message = parsed.Message;
                }

                if (parsed.Detail != null)
                {
                    _detail = parsed.Detail;
                }
            }
            catch (Exception)
            {
                // Just eat it
            }
        }

        internal class XmlMwsException : AbstractMwsObject
        {
            public string ErrorCode { get; private set; }

            public string ErrorType { get; private set; }

            public string Message { get; private set; }

            public string Detail { get; private set; }

            public override void ReadFragmentFrom(IMwsReader r)
            {
                ErrorType = r.Read<string>("Type");
                ErrorCode = r.Read<string>("Code");
                Message = r.Read<string>("Message");
                Detail = r.Read<string>("Detail");
            }

            public override void WriteFragmentTo(IMwsWriter w)
            {
                w.Write("Code", ErrorCode);
                w.Write("Type", ErrorType);
                w.Write("Message", Message);
                w.Write("Detail", Detail);
            }

            public override void WriteTo(IMwsWriter w)
            {
                w.Write("Error", this);
            }
        }
    }
}

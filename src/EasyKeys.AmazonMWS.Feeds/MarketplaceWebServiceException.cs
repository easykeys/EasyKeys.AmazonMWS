/*******************************************************************************
 *  Copyright 2009 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *
 *  You may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 17:31:42 PDT 2009
 *
 */

using System;
using System.Net;

using EasyKeys.AmazonMWS.Feeds.Model;

namespace EasyKeys.AmazonMWS.Feeds
{
    /// <summary>
    /// Marketplace Web Service  Exception provides details of errors
    /// returned by Marketplace Web Service  service.
    /// </summary>
    public class MarketplaceWebServiceException : Exception
    {
        private string _message = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceException"/> class.
        /// Constructs MarketplaceWebServiceException with message.
        /// </summary>
        /// <param name="message">Overview of error.</param>
        public MarketplaceWebServiceException(string message)
        {
            _message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceException"/> class.
        /// Constructs MarketplaceWebServiceException with message and status code.
        /// </summary>
        /// <param name="message">Overview of error.</param>
        /// <param name="statusCode">HTTP status code for error response.</param>
        /// <param name="rhm">Response Header Metadata.</param>
        public MarketplaceWebServiceException(string message, HttpStatusCode statusCode, ResponseHeaderMetadata rhm) : this(message)
        {
            StatusCode = statusCode;
            ResponseHeaderMetadata = rhm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceException"/> class.
        /// Constructs MarketplaceWebServiceException with wrapped exception.
        /// </summary>
        /// <param name="t">Wrapped exception.</param>
        public MarketplaceWebServiceException(Exception t) : this(t.Message, t)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceException"/> class.
        /// Constructs MarketplaceWebServiceException with message and wrapped exception.
        /// </summary>
        /// <param name="message">Overview of error.</param>
        /// <param name="t">Wrapped exception.</param>
        public MarketplaceWebServiceException(string message, Exception t) : base(message, t)
        {
            _message = message;
            if (t is MarketplaceWebServiceException ex)
            {
                StatusCode = ex.StatusCode;
                ErrorCode = ex.ErrorCode;
                ErrorType = ex.ErrorType;
                RequestId = ex.RequestId;
                XML = ex.XML;
                ResponseHeaderMetadata = ex.ResponseHeaderMetadata;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceException"/> class.
        /// Constructs MarketplaceWebServiceException with information available from service.
        /// </summary>
        /// <param name="message">Overview of error.</param>
        /// <param name="statusCode">HTTP status code for error response.</param>
        /// <param name="errorCode">Error Code returned by the service.</param>
        /// <param name="errorType">Error type. Possible types:  Sender, Receiver or Unknown.</param>
        /// <param name="requestId">Request ID returned by the service.</param>
        /// <param name="xml">Compete xml found in response.</param>
        /// <param name="rhm">Response Header Metadata.</param>
        public MarketplaceWebServiceException(string message, HttpStatusCode statusCode, string errorCode, string errorType, string requestId, string xml, ResponseHeaderMetadata rhm) : this(message, statusCode, rhm)
        {
            ErrorCode = errorCode;
            ErrorType = errorType;
            RequestId = requestId;
            XML = xml;
            ResponseHeaderMetadata = rhm;
        }

        /// <summary>
        /// Gets and sets of the ErrorCode property.
        /// </summary>
        public string ErrorCode { get; } = null;

        /// <summary>
        /// Gets and sets of the ErrorType property.
        /// </summary>
        public string ErrorType { get; } = null;

        /// <summary>
        /// Gets error message.
        /// </summary>
        public override string Message => _message;

        /// <summary>
        /// Gets status code returned by the service if available. If status
        /// code is set to -1, it means that status code was unavailable at the
        /// time exception was thrown.
        /// </summary>
        public HttpStatusCode StatusCode { get; } = default;

        /// <summary>
        /// Gets XML returned by the service if available.
        /// </summary>
        public string XML { get; } = null;

        /// <summary>
        /// Gets Request ID returned by the service if available.
        /// </summary>
        public string RequestId { get; } = null;

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; } = null;
    }
}

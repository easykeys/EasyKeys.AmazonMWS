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

using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class ErrorResponse
    {
        private List<Error> _errorField;

        /// <summary>
        /// Gets and sets the Error property.
        /// </summary>
        [XmlElement(ElementName = "Error")]
        public List<Error> Error
        {
            get => _errorField ?? (_errorField = new List<Error>());
            set => _errorField = value;
        }

        /// <summary>
        /// Sets the Error property.
        /// </summary>
        /// <param name="list">Error property.</param>
        /// <returns>this instance.</returns>
        public ErrorResponse WithError(params Error[] list)
        {
            foreach (var item in list)
            {
                Error.Add(item);
            }

            return this;
        }

        /// <summary>
        /// Checks if Error property is set.
        /// </summary>
        /// <returns>true if Error property is set.</returns>
        public bool IsSetError()
        {
            return Error.Count > 0;
        }

        /// <summary>
        /// Gets and sets the RequestId property.
        /// </summary>
        [XmlElement(ElementName = "RequestID")]
        public string RequestId { get; set; }

        /// <summary>
        /// Sets the RequestId property.
        /// </summary>
        /// <param name="requestId">RequestId property.</param>
        /// <returns>this instance.</returns>
        public ErrorResponse WithRequestId(string requestId)
        {
            RequestId = requestId;
            return this;
        }

        /// <summary>
        /// Checks if RequestId property is set.
        /// </summary>
        /// <returns>true if RequestId property is set.</returns>
        public bool IsSetRequestId()
        {
            return RequestId != null;
        }

        /// <summary>
        /// XML Representation for this object.
        /// </summary>
        /// <returns>XML String.</returns>
        public string ToXML()
        {
            var xml = new StringBuilder();
            xml.Append("<ErrorResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            var errorList = Error;
            foreach (var error in errorList)
            {
                xml.Append("<Error>");
                xml.Append(error.ToXMLFragment());
                xml.Append("</Error>");
            }

            if (IsSetRequestId())
            {
                xml.Append("<RequestId>");
                xml.Append(EscapeXML(RequestId));
                xml.Append("</RequestId>");
            }

            xml.Append("</ErrorResponse>");
            return xml.ToString();
        }

        /**
         *
         * Escape XML special characters
         */
        private string EscapeXML(string str)
        {
            var sb = new StringBuilder();
            foreach (var c in str)
            {
                switch (c)
                {
                    case '&':
                        sb.Append("&amp;");
                        break;
                    case '<':
                        sb.Append("&lt;");
                        break;
                    case '>':
                        sb.Append("&gt;");
                        break;
                    case '\'':
                        sb.Append("&#039;");
                        break;
                    case '"':
                        sb.Append("&quot;");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }

            return sb.ToString();
        }

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }
    }
}

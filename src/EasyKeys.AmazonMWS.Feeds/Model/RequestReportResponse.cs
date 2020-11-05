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
 */

using System.Text;
using System.Xml.Serialization;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class RequestReportResponse
    {
        /// <summary>
        /// Gets and sets the RequestReportResult property.
        /// </summary>
        [XmlElement(ElementName = "RequestReportResult")]
        public RequestReportResult RequestReportResult { get; set; }

        /// <summary>
        /// Sets the RequestReportResult property.
        /// </summary>
        /// <param name="requestReportResult">RequestReportResult property.</param>
        /// <returns>this instance.</returns>
        public RequestReportResponse WithRequestReportResult(RequestReportResult requestReportResult)
        {
            RequestReportResult = requestReportResult;
            return this;
        }

        /// <summary>
        /// Checks if RequestReportResult property is set.
        /// </summary>
        /// <returns>true if RequestReportResult property is set.</returns>
        public bool IsSetRequestReportResult()
        {
            return RequestReportResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElement(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata { get; set; }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public RequestReportResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            ResponseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return ResponseMetadata != null;
        }

        /// <summary>
        /// XML Representation for this object.
        /// </summary>
        /// <returns>XML String.</returns>
        public string ToXML()
        {
            var xml = new StringBuilder();
            xml.Append("<RequestReportResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            if (IsSetRequestReportResult())
            {
                var requestReportResult = RequestReportResult;
                xml.Append("<RequestReportResult>");
                xml.Append(requestReportResult.ToXMLFragment());
                xml.Append("</RequestReportResult>");
            }

            if (IsSetResponseMetadata())
            {
                var responseMetadata = ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            }

            xml.Append("</RequestReportResponse>");
            return xml.ToString();
        }

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }
    }
}

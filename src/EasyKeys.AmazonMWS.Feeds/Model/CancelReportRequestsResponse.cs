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
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class CancelReportRequestsResponse
    {
        /// <summary>
        /// Gets and sets the CancelReportRequestsResult property.
        /// </summary>
        [XmlElement(ElementName = "CancelReportRequestsResult")]
        public CancelReportRequestsResult CancelReportRequestsResult { get; set; }

        /// <summary>
        /// Sets the CancelReportRequestsResult property.
        /// </summary>
        /// <param name="cancelReportRequestsResult">CancelReportRequestsResult property.</param>
        /// <returns>this instance.</returns>
        public CancelReportRequestsResponse WithCancelReportRequestsResult(CancelReportRequestsResult cancelReportRequestsResult)
        {
            CancelReportRequestsResult = cancelReportRequestsResult;
            return this;
        }

        /// <summary>
        /// Checks if CancelReportRequestsResult property is set.
        /// </summary>
        /// <returns>true if CancelReportRequestsResult property is set.</returns>
        public bool IsSetCancelReportRequestsResult()
        {
            return CancelReportRequestsResult != null;
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
        public CancelReportRequestsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
            xml.Append("<CancelReportRequestsResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            if (IsSetCancelReportRequestsResult())
            {
                var cancelReportRequestsResult = CancelReportRequestsResult;
                xml.Append("<CancelReportRequestsResult>");
                xml.Append(cancelReportRequestsResult.ToXMLFragment());
                xml.Append("</CancelReportRequestsResult>");
            }

            if (IsSetResponseMetadata())
            {
                var responseMetadata = ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            }

            xml.Append("</CancelReportRequestsResponse>");
            return xml.ToString();
        }

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }
    }
}

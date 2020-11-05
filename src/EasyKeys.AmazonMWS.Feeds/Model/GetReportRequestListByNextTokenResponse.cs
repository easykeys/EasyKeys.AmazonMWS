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
    public class GetReportRequestListByNextTokenResponse
    {
        /// <summary>
        /// Gets and sets the GetReportRequestListByNextTokenResult property.
        /// </summary>
        [XmlElement(ElementName = "GetReportRequestListByNextTokenResult")]
        public GetReportRequestListByNextTokenResult GetReportRequestListByNextTokenResult { get; set; }

        /// <summary>
        /// Sets the GetReportRequestListByNextTokenResult property.
        /// </summary>
        /// <param name="getReportRequestListByNextTokenResult">GetReportRequestListByNextTokenResult property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestListByNextTokenResponse WithGetReportRequestListByNextTokenResult(GetReportRequestListByNextTokenResult getReportRequestListByNextTokenResult)
        {
            GetReportRequestListByNextTokenResult = getReportRequestListByNextTokenResult;
            return this;
        }

        /// <summary>
        /// Checks if GetReportRequestListByNextTokenResult property is set.
        /// </summary>
        /// <returns>true if GetReportRequestListByNextTokenResult property is set.</returns>
        public bool IsSetGetReportRequestListByNextTokenResult()
        {
            return GetReportRequestListByNextTokenResult != null;
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
        public GetReportRequestListByNextTokenResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
            xml.Append("<GetReportRequestListByNextTokenResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            if (IsSetGetReportRequestListByNextTokenResult())
            {
                var getReportRequestListByNextTokenResult = GetReportRequestListByNextTokenResult;
                xml.Append("<GetReportRequestListByNextTokenResult>");
                xml.Append(getReportRequestListByNextTokenResult.ToXMLFragment());
                xml.Append("</GetReportRequestListByNextTokenResult>");
            }

            if (IsSetResponseMetadata())
            {
                var responseMetadata = ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            }

            xml.Append("</GetReportRequestListByNextTokenResponse>");
            return xml.ToString();
        }

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }
    }
}

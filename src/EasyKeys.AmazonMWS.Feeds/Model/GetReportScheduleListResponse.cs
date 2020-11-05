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

using System.Text;
using System.Xml.Serialization;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class GetReportScheduleListResponse
    {
        /// <summary>
        /// Gets and sets the GetReportScheduleListResult property.
        /// </summary>
        [XmlElement(ElementName = "GetReportScheduleListResult")]
        public GetReportScheduleListResult GetReportScheduleListResult { get; set; }

        /// <summary>
        /// Sets the GetReportScheduleListResult property.
        /// </summary>
        /// <param name="getReportScheduleListResult">GetReportScheduleListResult property.</param>
        /// <returns>this instance.</returns>
        public GetReportScheduleListResponse WithGetReportScheduleListResult(GetReportScheduleListResult getReportScheduleListResult)
        {
            GetReportScheduleListResult = getReportScheduleListResult;
            return this;
        }

        /// <summary>
        /// Checks if GetReportScheduleListResult property is set.
        /// </summary>
        /// <returns>true if GetReportScheduleListResult property is set.</returns>
        public bool IsSetGetReportScheduleListResult()
        {
            return GetReportScheduleListResult != null;
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
        public GetReportScheduleListResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
            xml.Append("<GetReportScheduleListResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            if (IsSetGetReportScheduleListResult())
            {
                var getReportScheduleListResult = GetReportScheduleListResult;
                xml.Append("<GetReportScheduleListResult>");
                xml.Append(getReportScheduleListResult.ToXMLFragment());
                xml.Append("</GetReportScheduleListResult>");
            }

            if (IsSetResponseMetadata())
            {
                var responseMetadata = ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            }

            xml.Append("</GetReportScheduleListResponse>");
            return xml.ToString();
        }

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }
    }
}

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
    public class GetReportScheduleCountResponse
    {
        /// <summary>
        /// Gets and sets the GetReportScheduleCountResult property.
        /// </summary>
        [XmlElement(ElementName = "GetReportScheduleCountResult")]
        public GetReportScheduleCountResult GetReportScheduleCountResult { get; set; }

        /// <summary>
        /// Sets the GetReportScheduleCountResult property.
        /// </summary>
        /// <param name="getReportScheduleCountResult">GetReportScheduleCountResult property.</param>
        /// <returns>this instance.</returns>
        public GetReportScheduleCountResponse WithGetReportScheduleCountResult(GetReportScheduleCountResult getReportScheduleCountResult)
        {
            GetReportScheduleCountResult = getReportScheduleCountResult;
            return this;
        }

        /// <summary>
        /// Checks if GetReportScheduleCountResult property is set.
        /// </summary>
        /// <returns>true if GetReportScheduleCountResult property is set.</returns>
        public bool IsSetGetReportScheduleCountResult()
        {
            return GetReportScheduleCountResult != null;
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
        public GetReportScheduleCountResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
            xml.Append("<GetReportScheduleCountResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            if (IsSetGetReportScheduleCountResult())
            {
                var getReportScheduleCountResult = GetReportScheduleCountResult;
                xml.Append("<GetReportScheduleCountResult>");
                xml.Append(getReportScheduleCountResult.ToXMLFragment());
                xml.Append("</GetReportScheduleCountResult>");
            }

            if (IsSetResponseMetadata())
            {
                var responseMetadata = ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            }

            xml.Append("</GetReportScheduleCountResponse>");
            return xml.ToString();
        }

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }
    }
}

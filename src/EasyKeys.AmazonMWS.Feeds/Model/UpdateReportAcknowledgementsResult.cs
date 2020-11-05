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

namespace MarketplaceWebService.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class UpdateReportAcknowledgementsResult
    {
        private decimal? _countField;

        private List<ReportInfo> _reportInfoField;

        /// <summary>
        /// Gets and sets the Count property.
        /// </summary>
        [XmlElement(ElementName = "Count")]
        public decimal Count
        {
            get { return _countField.GetValueOrDefault(); }
            set { _countField = value; }
        }

        /// <summary>
        /// Sets the Count property.
        /// </summary>
        /// <param name="count">Count property.</param>
        /// <returns>this instance.</returns>
        public UpdateReportAcknowledgementsResult WithCount(decimal count)
        {
            _countField = count;
            return this;
        }

        /// <summary>
        /// Checks if Count property is set.
        /// </summary>
        /// <returns>true if Count property is set.</returns>
        public bool IsSetCount()
        {
            return _countField.HasValue;
        }

        /// <summary>
        /// Gets and sets the ReportInfo property.
        /// </summary>
        [XmlElement(ElementName = "ReportInfo")]
        public List<ReportInfo> ReportInfo
        {
            get
            {
                if (_reportInfoField == null)
                {
                    _reportInfoField = new List<ReportInfo>();
                }

                return _reportInfoField;
            }

            set { _reportInfoField = value; }
        }

        /// <summary>
        /// Sets the ReportInfo property.
        /// </summary>
        /// <param name="list">ReportInfo property.</param>
        /// <returns>this instance.</returns>
        public UpdateReportAcknowledgementsResult WithReportInfo(params ReportInfo[] list)
        {
            foreach (ReportInfo item in list)
            {
                ReportInfo.Add(item);
            }

            return this;
        }

        /// <summary>
        /// Checks if ReportInfo property is set.
        /// </summary>
        /// <returns>true if ReportInfo property is set.</returns>
        public bool IsSetReportInfo()
        {
            return (ReportInfo.Count > 0);
        }

        /// <summary>
        /// XML fragment representation of this object.
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only.
        /// </remarks>

        protected internal string ToXMLFragment()
        {
            StringBuilder xml = new StringBuilder();
            if (IsSetCount())
            {
                xml.Append("<Count>");
                xml.Append(Count);
                xml.Append("</Count>");
            }

            List<ReportInfo> reportInfoList = ReportInfo;
            foreach (ReportInfo reportInfo in reportInfoList)
            {
                xml.Append("<ReportInfo>");
                xml.Append(reportInfo.ToXMLFragment());
                xml.Append("</ReportInfo>");
            }

            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private string EscapeXML(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
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
    }
}

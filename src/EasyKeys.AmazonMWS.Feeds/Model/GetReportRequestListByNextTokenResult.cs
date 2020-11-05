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
    public class GetReportRequestListByNextTokenResult
    {
        private bool? _hasNextField;

        private List<ReportRequestInfo> _reportRequestInfoField;

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        [XmlElement(ElementName = "NextToken")]
        public string NextToken { get; set; }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestListByNextTokenResult WithNextToken(string nextToken)
        {
            NextToken = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set.</returns>
        public bool IsSetNextToken()
        {
            return NextToken != null;
        }

        /// <summary>
        /// Gets and sets the HasNext property.
        /// </summary>
        [XmlElement(ElementName = "HasNext")]
        public bool HasNext
        {
            get { return _hasNextField.GetValueOrDefault(); }
            set { _hasNextField = value; }
        }

        /// <summary>
        /// Sets the HasNext property.
        /// </summary>
        /// <param name="hasNext">HasNext property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestListByNextTokenResult WithHasNext(bool hasNext)
        {
            _hasNextField = hasNext;
            return this;
        }

        /// <summary>
        /// Checks if HasNext property is set.
        /// </summary>
        /// <returns>true if HasNext property is set.</returns>
        public bool IsSetHasNext()
        {
            return _hasNextField.HasValue;
        }

        /// <summary>
        /// Gets and sets the ReportRequestInfo property.
        /// </summary>
        [XmlElement(ElementName = "ReportRequestInfo")]
        public List<ReportRequestInfo> ReportRequestInfo
        {
            get
            {
                if (_reportRequestInfoField == null)
                {
                    _reportRequestInfoField = new List<ReportRequestInfo>();
                }

                return _reportRequestInfoField;
            }

            set { _reportRequestInfoField = value; }
        }

        /// <summary>
        /// Sets the ReportRequestInfo property.
        /// </summary>
        /// <param name="list">ReportRequestInfo property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestListByNextTokenResult WithReportRequestInfo(params ReportRequestInfo[] list)
        {
            foreach (ReportRequestInfo item in list)
            {
                ReportRequestInfo.Add(item);
            }

            return this;
        }

        /// <summary>
        /// Checks if ReportRequestInfo property is set.
        /// </summary>
        /// <returns>true if ReportRequestInfo property is set.</returns>
        public bool IsSetReportRequestInfo()
        {
            return (ReportRequestInfo.Count > 0);
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
            if (IsSetNextToken())
            {
                xml.Append("<NextToken>");
                xml.Append(EscapeXML(NextToken));
                xml.Append("</NextToken>");
            }

            if (IsSetHasNext())
            {
                xml.Append("<HasNext>");
                xml.Append(HasNext);
                xml.Append("</HasNext>");
            }

            List<ReportRequestInfo> reportRequestInfoList = ReportRequestInfo;
            foreach (ReportRequestInfo reportRequestInfo in reportRequestInfoList)
            {
                xml.Append("<ReportRequestInfo>");
                xml.Append(reportRequestInfo.ToXMLFragment());
                xml.Append("</ReportRequestInfo>");
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

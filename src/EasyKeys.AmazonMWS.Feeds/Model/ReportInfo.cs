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
    public class ReportInfo
    {
        private string _reportRequestIdField;

        private DateTime? _availableDateField;

        private bool? _acknowledgedField;

        private DateTime? _acknowledgedDateField;

        /// <summary>
        /// Gets and sets the ReportId property.
        /// </summary>
        [XmlElement(ElementName = "ReportId")]
        public string ReportId { get; set; }

        /// <summary>
        /// Sets the ReportId property.
        /// </summary>
        /// <param name="reportId">ReportId property.</param>
        /// <returns>this instance.</returns>
        public ReportInfo WithReportId(string reportId)
        {
            ReportId = reportId;
            return this;
        }

        /// <summary>
        /// Checks if ReportId property is set.
        /// </summary>
        /// <returns>true if ReportId property is set.</returns>
        public bool IsSetReportId()
        {
            return ReportId != null;
        }

        /// <summary>
        /// Gets and sets the ReportType property.
        /// </summary>
        [XmlElement(ElementName = "ReportType")]
        public string ReportType { get; set; }

        /// <summary>
        /// Sets the ReportType property.
        /// </summary>
        /// <param name="reportType">ReportType property.</param>
        /// <returns>this instance.</returns>
        public ReportInfo WithReportType(string reportType)
        {
            ReportType = reportType;
            return this;
        }

        /// <summary>
        /// Checks if ReportType property is set.
        /// </summary>
        /// <returns>true if ReportType property is set.</returns>
        public bool IsSetReportType()
        {
            return ReportType != null;
        }

        /// <summary>
        /// Gets and sets the ReportRequestId property.
        /// </summary>
        [XmlElement(ElementName = "ReportRequestId")]
        public string ReportRequestId
        {
            get { return _reportRequestIdField; }
            set { _reportRequestIdField = value; }
        }

        /// <summary>
        /// Sets the ReportRequestId property.
        /// </summary>
        /// <param name="reportRequestId">ReportRequestId property.</param>
        /// <returns>this instance.</returns>
        public ReportInfo WithReportRequestId(string reportRequestId)
        {
            _reportRequestIdField = reportRequestId;
            return this;
        }

        /// <summary>
        /// Checks if ReportRequestId property is set.
        /// </summary>
        /// <returns>true if ReportRequestId property is set.</returns>
        public bool IsSetReportRequestId()
        {
            return _reportRequestIdField != null;
        }

        /// <summary>
        /// Gets and sets the AvailableDate property.
        /// </summary>
        [XmlElement(ElementName = "AvailableDate")]
        public DateTime AvailableDate
        {
            get { return _availableDateField.GetValueOrDefault(); }
            set { _availableDateField = value; }
        }

        /// <summary>
        /// Sets the AvailableDate property.
        /// </summary>
        /// <param name="availableDate">AvailableDate property.</param>
        /// <returns>this instance.</returns>
        public ReportInfo WithAvailableDate(DateTime availableDate)
        {
            _availableDateField = availableDate;
            return this;
        }

        /// <summary>
        /// Checks if AvailableDate property is set.
        /// </summary>
        /// <returns>true if AvailableDate property is set.</returns>
        public bool IsSetAvailableDate()
        {
            return _availableDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Acknowledged property.
        /// </summary>
        [XmlElement(ElementName = "Acknowledged")]
        public bool Acknowledged
        {
            get { return _acknowledgedField.GetValueOrDefault(); }
            set { _acknowledgedField = value; }
        }

        /// <summary>
        /// Sets the Acknowledged property.
        /// </summary>
        /// <param name="acknowledged">Acknowledged property.</param>
        /// <returns>this instance.</returns>
        public ReportInfo WithAcknowledged(bool acknowledged)
        {
            _acknowledgedField = acknowledged;
            return this;
        }

        /// <summary>
        /// Checks if Acknowledged property is set.
        /// </summary>
        /// <returns>true if Acknowledged property is set.</returns>
        public bool IsSetAcknowledged()
        {
            return _acknowledgedField.HasValue;
        }

        /// <summary>
        /// Gets and sets the AcknowledgedDate property.
        /// </summary>
        [XmlElement(ElementName = "AcknowledgedDate")]
        public DateTime AcknowledgedDate
        {
            get { return _acknowledgedDateField.GetValueOrDefault(); }
            set { _acknowledgedDateField = value; }
        }

        /// <summary>
        /// Sets the AcknowledgedDate property.
        /// </summary>
        /// <param name="acknowledgedDate">AcknowledgedDate property.</param>
        /// <returns>this instance.</returns>
        public ReportInfo WithAcknowledgedDate(DateTime acknowledgedDate)
        {
            _acknowledgedDateField = acknowledgedDate;
            return this;
        }

        /// <summary>
        /// Checks if AcknowledgedDate property is set.
        /// </summary>
        /// <returns>true if AcknowledgedDate property is set.</returns>
        public bool IsSetAcknowledgedDate()
        {
            return _acknowledgedDateField.HasValue;
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
            if (IsSetReportId())
            {
                xml.Append("<ReportId>");
                xml.Append(EscapeXML(ReportId));
                xml.Append("</ReportId>");
            }

            if (IsSetReportType())
            {
                xml.Append("<ReportType>");
                xml.Append(EscapeXML(ReportType));
                xml.Append("</ReportType>");
            }

            if (IsSetReportRequestId())
            {
                xml.Append("<ReportRequestId>");
                xml.Append(EscapeXML(ReportRequestId));
                xml.Append("</ReportRequestId>");
            }

            if (IsSetAvailableDate())
            {
                xml.Append("<AvailableDate>");
                xml.Append(AvailableDate);
                xml.Append("</AvailableDate>");
            }

            if (IsSetAcknowledged())
            {
                xml.Append("<Acknowledged>");
                xml.Append(Acknowledged);
                xml.Append("</Acknowledged>");
            }

            if (IsSetAcknowledgedDate())
            {
                xml.Append("<AcknowledgedDate>");
                xml.Append(AcknowledgedDate);
                xml.Append("</AcknowledgedDate>");
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

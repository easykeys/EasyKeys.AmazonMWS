/*******************************************************************************
 *  Copyright 2008 Amazon Technologies, Inc.
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *
 *  You may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Fri Feb 13 19:54:50 PST 2009
 *
 */

using System;
using System.Text;
using System.Xml.Serialization;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class Report
    {
        private DateTime? _availableDateField;

        private bool? _acknowledgedField;

        private DateTime? _ackowledgedDateField;

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
        public Report WithReportId(string reportId)
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
        public Report WithReportType(string reportType)
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
        public string ReportRequestId { get; set; }

        /// <summary>
        /// Sets the ReportRequestId property.
        /// </summary>
        /// <param name="reportRequestId">ReportRequestId property.</param>
        /// <returns>this instance.</returns>
        public Report WithReportRequestId(string reportRequestId)
        {
            ReportRequestId = reportRequestId;
            return this;
        }

        /// <summary>
        /// Checks if ReportRequestId property is set.
        /// </summary>
        /// <returns>true if ReportRequestId property is set.</returns>
        public bool IsSetReportRequestId()
        {
            return ReportRequestId != null;
        }

        /// <summary>
        /// Gets and sets the AvailableDate property.
        /// </summary>
        [XmlElement(ElementName = "AvailableDate")]
        public DateTime AvailableDate
        {
            get => _availableDateField.GetValueOrDefault();
            set => _availableDateField = value;
        }

        /// <summary>
        /// Sets the AvailableDate property.
        /// </summary>
        /// <param name="availableDate">AvailableDate property.</param>
        /// <returns>this instance.</returns>
        public Report WithAvailableDate(DateTime availableDate)
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
            get => _acknowledgedField.GetValueOrDefault();
            set => _acknowledgedField = value;
        }

        /// <summary>
        /// Sets the Acknowledged property.
        /// </summary>
        /// <param name="acknowledged">Acknowledged property.</param>
        /// <returns>this instance.</returns>
        public Report WithAcknowledged(bool acknowledged)
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
        /// Gets and sets the AckowledgedDate property.
        /// </summary>
        [XmlElement(ElementName = "AckowledgedDate")]
        public DateTime AckowledgedDate
        {
            get => _ackowledgedDateField.GetValueOrDefault();
            set => _ackowledgedDateField = value;
        }

        /// <summary>
        /// Sets the AckowledgedDate property.
        /// </summary>
        /// <param name="ackowledgedDate">AckowledgedDate property.</param>
        /// <returns>this instance.</returns>
        public Report WithAckowledgedDate(DateTime ackowledgedDate)
        {
            _ackowledgedDateField = ackowledgedDate;
            return this;
        }

        /// <summary>
        /// Checks if AckowledgedDate property is set.
        /// </summary>
        /// <returns>true if AckowledgedDate property is set.</returns>
        public bool IsSetAckowledgedDate()
        {
            return _ackowledgedDateField.HasValue;
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
            var xml = new StringBuilder();
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

            if (IsSetAckowledgedDate())
            {
                xml.Append("<AckowledgedDate>");
                xml.Append(AckowledgedDate);
                xml.Append("</AckowledgedDate>");
            }

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
    }
}

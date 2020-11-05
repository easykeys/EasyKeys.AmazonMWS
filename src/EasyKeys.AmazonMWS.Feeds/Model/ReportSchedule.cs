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
    public class ReportSchedule
    {
        private DateTime? _scheduledDateField;

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
        public ReportSchedule WithReportType(string reportType)
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
        /// Gets and sets the Schedule property.
        /// </summary>
        [XmlElement(ElementName = "Schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// Sets the Schedule property.
        /// </summary>
        /// <param name="schedule">Schedule property.</param>
        /// <returns>this instance.</returns>
        public ReportSchedule WithSchedule(string schedule)
        {
            Schedule = schedule;
            return this;
        }

        /// <summary>
        /// Checks if Schedule property is set.
        /// </summary>
        /// <returns>true if Schedule property is set.</returns>
        public bool IsSetSchedule()
        {
            return Schedule != null;
        }

        /// <summary>
        /// Gets and sets the ScheduledDate property.
        /// </summary>
        [XmlElement(ElementName = "ScheduledDate")]
        public DateTime ScheduledDate
        {
            get { return _scheduledDateField.GetValueOrDefault(); }
            set { _scheduledDateField = value; }
        }

        /// <summary>
        /// Sets the ScheduledDate property.
        /// </summary>
        /// <param name="scheduledDate">ScheduledDate property.</param>
        /// <returns>this instance.</returns>
        public ReportSchedule WithScheduledDate(DateTime scheduledDate)
        {
            _scheduledDateField = scheduledDate;
            return this;
        }

        /// <summary>
        /// Checks if ScheduledDate property is set.
        /// </summary>
        /// <returns>true if ScheduledDate property is set.</returns>
        public bool IsSetScheduledDate()
        {
            return _scheduledDateField.HasValue;
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
            if (IsSetReportType())
            {
                xml.Append("<ReportType>");
                xml.Append(EscapeXML(ReportType));
                xml.Append("</ReportType>");
            }

            if (IsSetSchedule())
            {
                xml.Append("<Schedule>");
                xml.Append(EscapeXML(Schedule));
                xml.Append("</Schedule>");
            }

            if (IsSetScheduledDate())
            {
                xml.Append("<ScheduledDate>");
                xml.Append(ScheduledDate);
                xml.Append("</ScheduledDate>");
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

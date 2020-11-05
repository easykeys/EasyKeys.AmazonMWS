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
using System.Text;
using System.Xml.Serialization;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class ReportRequestInfo
    {
        private DateTime? _startDateField;

        private DateTime? _endDateField;
        private DateTime? _submittedDateField;
        private DateTime? _startedProcessingDateField;

        private DateTime? _completedDateField;

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
        public ReportRequestInfo WithReportRequestId(string reportRequestId)
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
        /// Gets and sets the ReportType property.
        /// </summary>
        [XmlElement(ElementName = "ReportType")]
        public string ReportType { get; set; }

        /// <summary>
        /// Sets the ReportType property.
        /// </summary>
        /// <param name="reportType">ReportType property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithReportType(string reportType)
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
        /// Gets and sets the StartDate property.
        /// </summary>
        [XmlElement(ElementName = "StartDate")]
        public DateTime StartDate
        {
            get => _startDateField.GetValueOrDefault();
            set => _startDateField = value;
        }

        /// <summary>
        /// Sets the StartDate property.
        /// </summary>
        /// <param name="startDate">StartDate property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithStartDate(DateTime startDate)
        {
            _startDateField = startDate;
            return this;
        }

        /// <summary>
        /// Checks if StartDate property is set.
        /// </summary>
        /// <returns>true if StartDate property is set.</returns>
        public bool IsSetStartDate()
        {
            return _startDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the EndDate property.
        /// </summary>
        [XmlElement(ElementName = "EndDate")]
        public DateTime EndDate
        {
            get => _endDateField.GetValueOrDefault();
            set => _endDateField = value;
        }

        /// <summary>
        /// Sets the EndDate property.
        /// </summary>
        /// <param name="endDate">EndDate property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithEndDate(DateTime endDate)
        {
            _endDateField = endDate;
            return this;
        }

        /// <summary>
        /// Checks if EndDate property is set.
        /// </summary>
        /// <returns>true if EndDate property is set.</returns>
        public bool IsSetEndDate()
        {
            return _endDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Scheduled property.
        /// </summary>
        [XmlElement(ElementName = "Scheduled")]
        public bool Scheduled { get; set; }

        /// <summary>
        /// Sets the Scheduled property.
        /// </summary>
        /// <param name="scheduled">Scheduled property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithScheduled(bool scheduled)
        {
            Scheduled = scheduled;
            return this;
        }

        /// <summary>
        /// Checks if Scheduled property is set.
        /// </summary>
        /// <returns>true if Scheduled property is set.</returns>
        public bool IsSetScheduled()
        {
            return Scheduled != null;
        }

        /// <summary>
        /// Gets and sets the SubmittedDate property.
        /// </summary>
        [XmlElement(ElementName = "SubmittedDate")]
        public DateTime SubmittedDate
        {
            get => _submittedDateField.GetValueOrDefault();
            set => _submittedDateField = value;
        }

        /// <summary>
        /// Sets the SubmittedDate property.
        /// </summary>
        /// <param name="submittedDate">SubmittedDate property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithSubmittedDate(DateTime submittedDate)
        {
            _submittedDateField = submittedDate;
            return this;
        }

        /// <summary>
        /// Checks if SubmittedDate property is set.
        /// </summary>
        /// <returns>true if SubmittedDate property is set.</returns>
        public bool IsSetSubmittedDate()
        {
            return _submittedDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the ReportProcessingStatus property.
        /// </summary>
        [XmlElement(ElementName = "ReportProcessingStatus")]
        public string ReportProcessingStatus { get; set; }

        /// <summary>
        /// Sets the ReportProcessingStatus property.
        /// </summary>
        /// <param name="reportProcessingStatus">ReportProcessingStatus property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithReportProcessingStatus(string reportProcessingStatus)
        {
            ReportProcessingStatus = reportProcessingStatus;
            return this;
        }

        /// <summary>
        /// Checks if ReportProcessingStatus property is set.
        /// </summary>
        /// <returns>true if ReportProcessingStatus property is set.</returns>
        public bool IsSetReportProcessingStatus()
        {
            return ReportProcessingStatus != null;
        }

        /// <summary>
        /// Gets and sets the GeneratedReportId property.
        /// </summary>
        [XmlElement(ElementName = "GeneratedReportId")]
        public string GeneratedReportId { get; set; }

        /// <summary>
        /// Sets the GeneratedReportId property.
        /// </summary>
        /// <param name="reportRequestId">GeneratedReportId property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithGeneratedReportId(string generatedReportId)
        {
            GeneratedReportId = generatedReportId;
            return this;
        }

        /// <summary>
        /// Checks if GeneratedReportId property is set.
        /// </summary>
        /// <returns>true if GeneratedReportId property is set.</returns>
        public bool IsSetGeneratedReportId()
        {
            return GeneratedReportId != null;
        }

        /// <summary>
        /// Gets and sets the StartedProcessingDate property.
        /// </summary>
        [XmlElement(ElementName = "StartedProcessingDate")]
        public DateTime StartedProcessingDate
        {
            get => _startedProcessingDateField.GetValueOrDefault();
            set => _startedProcessingDateField = value;
        }

        /// <summary>
        /// Sets the StartedProcessingDate property.
        /// </summary>
        /// <param name="startedProcessingDate">StartedProcessingDate property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithStartedProcessingDate(DateTime startedProcessingDate)
        {
            _startedProcessingDateField = startedProcessingDate;
            return this;
        }

        /// <summary>
        /// Checks if StartedProcessingDate property is set.
        /// </summary>
        /// <returns>true if StartedProcessingDate property is set.</returns>
        public bool IsSetStartedProcessingDate()
        {
            return _startedProcessingDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the CompletedDate property.
        /// </summary>
        [XmlElement(ElementName = "CompletedDate")]
        public DateTime CompletedDate
        {
            get => _completedDateField.GetValueOrDefault();
            set => _completedDateField = value;
        }

        /// <summary>
        /// Sets the CompletedDate property.
        /// </summary>
        /// <param name="completedDate">CompletedDate property.</param>
        /// <returns>this instance.</returns>
        public ReportRequestInfo WithCompletedDate(DateTime completedDate)
        {
            _completedDateField = completedDate;
            return this;
        }

        /// <summary>
        /// Checks if CompletedDate property is set.
        /// </summary>
        /// <returns>true if CompletedDate property is set.</returns>
        public bool IsSetCompletedDate()
        {
            return _completedDateField.HasValue;
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
            if (IsSetReportRequestId())
            {
                xml.Append("<ReportRequestId>");
                xml.Append(EscapeXML(ReportRequestId));
                xml.Append("</ReportRequestId>");
            }

            if (IsSetReportType())
            {
                xml.Append("<ReportType>");
                xml.Append(EscapeXML(ReportType));
                xml.Append("</ReportType>");
            }

            if (IsSetStartDate())
            {
                xml.Append("<StartDate>");
                xml.Append(StartDate);
                xml.Append("</StartDate>");
            }

            if (IsSetEndDate())
            {
                xml.Append("<EndDate>");
                xml.Append(EndDate);
                xml.Append("</EndDate>");
            }

            if (IsSetScheduled())
            {
                xml.Append("<Scheduled>");
                xml.Append(Scheduled);
                xml.Append("</Scheduled>");
            }

            if (IsSetSubmittedDate())
            {
                xml.Append("<SubmittedDate>");
                xml.Append(SubmittedDate);
                xml.Append("</SubmittedDate>");
            }

            if (IsSetReportProcessingStatus())
            {
                xml.Append("<ReportProcessingStatus>");
                xml.Append(EscapeXML(ReportProcessingStatus));
                xml.Append("</ReportProcessingStatus>");
            }

            if (IsSetGeneratedReportId())
            {
                xml.Append("<GeneratedReportId>");
                xml.Append(EscapeXML(GeneratedReportId));
                xml.Append("</GeneratedReportId>");
            }

            if (IsSetStartedProcessingDate())
            {
                xml.Append("<StartedProcessingDate>");
                xml.Append(StartedProcessingDate);
                xml.Append("</StartedProcessingDate>");
            }

            if (IsSetCompletedDate())
            {
                xml.Append("<CompletedDate>");
                xml.Append(CompletedDate);
                xml.Append("</CompletedDate>");
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

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
    public class FeedSubmissionInfo
    {
        private DateTime? _startedProcessingDateField;

        private DateTime? _completedProcessingDateField;

        /// <summary>
        /// Gets and sets the FeedSubmissionId property.
        /// </summary>
        [XmlElement(ElementName = "FeedSubmissionId")]
        public string FeedSubmissionId { get; set; }

        /// <summary>
        /// Sets the FeedSubmissionId property.
        /// </summary>
        /// <param name="feedSubmissionId">FeedSubmissionId property.</param>
        /// <returns>this instance.</returns>
        public FeedSubmissionInfo WithFeedSubmissionId(string feedSubmissionId)
        {
            FeedSubmissionId = feedSubmissionId;
            return this;
        }

        /// <summary>
        /// Checks if FeedSubmissionId property is set.
        /// </summary>
        /// <returns>true if FeedSubmissionId property is set.</returns>
        public bool IsSetFeedSubmissionId()
        {
            return FeedSubmissionId != null;
        }

        /// <summary>
        /// Gets and sets the FeedType property.
        /// </summary>
        [XmlElement(ElementName = "FeedType")]
        public string FeedType { get; set; }

        /// <summary>
        /// Sets the FeedType property.
        /// </summary>
        /// <param name="feedType">FeedType property.</param>
        /// <returns>this instance.</returns>
        public FeedSubmissionInfo WithFeedType(string feedType)
        {
            FeedType = feedType;
            return this;
        }

        /// <summary>
        /// Checks if FeedType property is set.
        /// </summary>
        /// <returns>true if FeedType property is set.</returns>
        public bool IsSetFeedType()
        {
            return FeedType != null;
        }

        /// <summary>
        /// Gets and sets the SubmittedDate property.
        /// </summary>
        [XmlElement(ElementName = "SubmittedDate")]
        public string SubmittedDate { get; set; }

        /// <summary>
        /// Sets the SubmittedDate property.
        /// </summary>
        /// <param name="submittedDate">SubmittedDate property.</param>
        /// <returns>this instance.</returns>
        public FeedSubmissionInfo WithSubmittedDate(string submittedDate)
        {
            SubmittedDate = submittedDate;
            return this;
        }

        /// <summary>
        /// Checks if SubmittedDate property is set.
        /// </summary>
        /// <returns>true if SubmittedDate property is set.</returns>
        public bool IsSetSubmittedDate()
        {
            return SubmittedDate != null;
        }

        /// <summary>
        /// Gets and sets the FeedProcessingStatus property.
        /// </summary>
        [XmlElement(ElementName = "FeedProcessingStatus")]
        public string FeedProcessingStatus { get; set; }

        /// <summary>
        /// Sets the FeedProcessingStatus property.
        /// </summary>
        /// <param name="feedProcessingStatus">FeedProcessingStatus property.</param>
        /// <returns>this instance.</returns>
        public FeedSubmissionInfo WithFeedProcessingStatus(string feedProcessingStatus)
        {
            FeedProcessingStatus = feedProcessingStatus;
            return this;
        }

        /// <summary>
        /// Checks if FeedProcessingStatus property is set.
        /// </summary>
        /// <returns>true if FeedProcessingStatus property is set.</returns>
        public bool IsSetFeedProcessingStatus()
        {
            return FeedProcessingStatus != null;
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
        public FeedSubmissionInfo WithStartedProcessingDate(DateTime startedProcessingDate)
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
        /// Gets and sets the CompletedProcessingDate property.
        /// </summary>
        [XmlElement(ElementName = "CompletedProcessingDate")]
        public DateTime CompletedProcessingDate
        {
            get => _completedProcessingDateField.GetValueOrDefault();
            set => _completedProcessingDateField = value;
        }

        /// <summary>
        /// Sets the CompletedProcessingDate property.
        /// </summary>
        /// <param name="completedProcessingDate">CompletedProcessingDate property.</param>
        /// <returns>this instance.</returns>
        public FeedSubmissionInfo WithCompletedProcessingDate(DateTime completedProcessingDate)
        {
            _completedProcessingDateField = completedProcessingDate;
            return this;
        }

        /// <summary>
        /// Checks if CompletedProcessingDate property is set.
        /// </summary>
        /// <returns>true if CompletedProcessingDate property is set.</returns>
        public bool IsSetCompletedProcessingDate()
        {
            return _completedProcessingDateField.HasValue;
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
            if (IsSetFeedSubmissionId())
            {
                xml.Append("<FeedSubmissionId>");
                xml.Append(EscapeXML(FeedSubmissionId));
                xml.Append("</FeedSubmissionId>");
            }

            if (IsSetFeedType())
            {
                xml.Append("<FeedType>");
                xml.Append(EscapeXML(FeedType));
                xml.Append("</FeedType>");
            }

            if (IsSetSubmittedDate())
            {
                xml.Append("<SubmittedDate>");
                xml.Append(EscapeXML(SubmittedDate));
                xml.Append("</SubmittedDate>");
            }

            if (IsSetFeedProcessingStatus())
            {
                xml.Append("<FeedProcessingStatus>");
                xml.Append(EscapeXML(FeedProcessingStatus));
                xml.Append("</FeedProcessingStatus>");
            }

            if (IsSetStartedProcessingDate())
            {
                xml.Append("<StartedProcessingDate>");
                xml.Append(StartedProcessingDate);
                xml.Append("</StartedProcessingDate>");
            }

            if (IsSetCompletedProcessingDate())
            {
                xml.Append("<CompletedProcessingDate>");
                xml.Append(CompletedProcessingDate);
                xml.Append("</CompletedProcessingDate>");
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

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

using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class ManageReportScheduleList
    {
        private List<ReportSchedule> _reportScheduleField;

        /// <summary>
        /// Gets and sets the ReportSchedule property.
        /// </summary>
        [XmlElement(ElementName = "ReportSchedule")]
        public List<ReportSchedule> ReportSchedule
        {
            get => _reportScheduleField ?? (_reportScheduleField = new List<ReportSchedule>());
            set => _reportScheduleField = value;
        }

        /// <summary>
        /// Sets the ReportSchedule property.
        /// </summary>
        /// <param name="list">ReportSchedule property.</param>
        /// <returns>this instance.</returns>
        public ManageReportScheduleList WithReportSchedule(params ReportSchedule[] list)
        {
            foreach (var item in list)
            {
                ReportSchedule.Add(item);
            }

            return this;
        }

        /// <summary>
        /// Checks if ReportSchedule property is set.
        /// </summary>
        /// <returns>true if ReportSchedule property is set.</returns>
        public bool IsSetReportSchedule()
        {
            return ReportSchedule.Count > 0;
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
            var reportScheduleList = ReportSchedule;
            foreach (var reportSchedule in reportScheduleList)
            {
                xml.Append("<ReportSchedule>");
                xml.Append(reportSchedule.ToXMLFragment());
                xml.Append("</ReportSchedule>");
            }

            return xml.ToString();
        }
    }
}

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
    public class GetReportRequestCountResult
    {
        private decimal? _countField;

        /// <summary>
        /// Gets and sets the Count property.
        /// </summary>
        [XmlElement(ElementName = "Count")]
        public decimal Count
        {
            get => _countField.GetValueOrDefault();
            set => _countField = value;
        }

        /// <summary>
        /// Sets the Count property.
        /// </summary>
        /// <param name="count">Count property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestCountResult WithCount(decimal count)
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
            if (IsSetCount())
            {
                xml.Append("<Count>");
                xml.Append(Count);
                xml.Append("</Count>");
            }

            return xml.ToString();
        }
    }
}

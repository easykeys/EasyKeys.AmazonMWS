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

using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class IdList
    {
        private List<string> _idField;

        /// <summary>
        /// Gets and sets the Id property.
        /// </summary>
        [XmlElement(ElementName = "Id")]
        public List<string> Id
        {
            get => _idField ?? (_idField = new List<string>());
            set => _idField = value;
        }

        /// <summary>
        /// Sets the Id property.
        /// </summary>
        /// <param name="list">Id property.</param>
        /// <returns>this instance.</returns>
        public IdList WithId(params string[] list)
        {
            foreach (var item in list)
            {
                Id.Add(item);
            }

            return this;
        }

        /// <summary>
        /// Checks of Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        public bool IsSetId()
        {
            return Id.Count > 0;
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
            var idList = Id;
            foreach (var id in idList)
            {
                xml.Append("<Id>");
                xml.Append(EscapeXML(id));
                xml.Append("</Id>");
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

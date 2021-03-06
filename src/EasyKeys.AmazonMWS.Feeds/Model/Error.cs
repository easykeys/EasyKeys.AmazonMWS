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
    public class Error
    {
        /// <summary>
        /// Gets and sets the Type property.
        /// </summary>
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Sets the Type property.
        /// </summary>
        /// <param name="type">Type property.</param>
        /// <returns>this instance.</returns>
        public Error WithType(string type)
        {
            Type = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set.
        /// </summary>
        /// <returns>true if Type property is set.</returns>
        public bool IsSetType()
        {
            return Type != null;
        }

        /// <summary>
        /// Gets and sets the Code property.
        /// </summary>
        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// Sets the Code property.
        /// </summary>
        /// <param name="code">Code property.</param>
        /// <returns>this instance.</returns>
        public Error WithCode(string code)
        {
            Code = code;
            return this;
        }

        /// <summary>
        /// Checks if Code property is set.
        /// </summary>
        /// <returns>true if Code property is set.</returns>
        public bool IsSetCode()
        {
            return Code != null;
        }

        /// <summary>
        /// Gets and sets the Message property.
        /// </summary>
        [XmlElement(ElementName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Sets the Message property.
        /// </summary>
        /// <param name="message">Message property.</param>
        /// <returns>this instance.</returns>
        public Error WithMessage(string message)
        {
            Message = message;
            return this;
        }

        /// <summary>
        /// Checks if Message property is set.
        /// </summary>
        /// <returns>true if Message property is set.</returns>
        public bool IsSetMessage()
        {
            return Message != null;
        }

        /// <summary>
        /// Gets and sets the Detail property.
        /// </summary>
        [XmlElement(ElementName = "Detail")]
        public object Detail { get; set; }

        /// <summary>
        /// Sets the Detail property.
        /// </summary>
        /// <param name="detail">Detail property.</param>
        /// <returns>this instance.</returns>
        public Error WithDetail(object detail)
        {
            Detail = detail;
            return this;
        }

        /// <summary>
        /// Checks if Detail property is set.
        /// </summary>
        /// <returns>true if Detail property is set.</returns>
        public bool IsSetDetail()
        {
            return Detail != null;
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
            if (IsSetType())
            {
                xml.Append("<Type>");
                xml.Append(Type);
                xml.Append("</Type>");
            }

            if (IsSetCode())
            {
                xml.Append("<Code>");
                xml.Append(EscapeXML(Code));
                xml.Append("</Code>");
            }

            if (IsSetMessage())
            {
                xml.Append("<Message>");
                xml.Append(EscapeXML(Message));
                xml.Append("</Message>");
            }

            if (IsSetDetail())
            {
                var detail = Detail;
                xml.Append("<Detail>");
                xml.Append(detail.ToString());
                xml.Append("</Detail>");
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

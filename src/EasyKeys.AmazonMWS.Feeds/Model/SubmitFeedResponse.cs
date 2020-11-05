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
    public class SubmitFeedResponse
    {
        private ResponseMetadata _responseMetadataField;

        /// <summary>
        /// Gets and sets the SubmitFeedResult property.
        /// </summary>
        [XmlElement(ElementName = "SubmitFeedResult")]
        public SubmitFeedResult SubmitFeedResult { get; set; }

        /// <summary>
        /// Sets the SubmitFeedResult property.
        /// </summary>
        /// <param name="submitFeedResult">SubmitFeedResult property.</param>
        /// <returns>this instance.</returns>
        public SubmitFeedResponse WithSubmitFeedResult(SubmitFeedResult submitFeedResult)
        {
            SubmitFeedResult = submitFeedResult;
            return this;
        }

        /// <summary>
        /// Checks if SubmitFeedResult property is set.
        /// </summary>
        /// <returns>true if SubmitFeedResult property is set.</returns>
        public bool IsSetSubmitFeedResult()
        {
            return SubmitFeedResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElement(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return _responseMetadataField; }
            set { _responseMetadataField = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public SubmitFeedResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            _responseMetadataField = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return _responseMetadataField != null;
        }

        /// <summary>
        /// XML Representation for this object.
        /// </summary>
        /// <returns>XML String.</returns>

        public string ToXML()
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<SubmitFeedResponse xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">");
            if (IsSetSubmitFeedResult())
            {
                SubmitFeedResult submitFeedResult = SubmitFeedResult;
                xml.Append("<SubmitFeedResult>");
                xml.Append(submitFeedResult.ToXMLFragment());
                xml.Append("</SubmitFeedResult>");
            }

            if (IsSetResponseMetadata())
            {
                ResponseMetadata responseMetadata = ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            }

            xml.Append("</SubmitFeedResponse>");
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

        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }
    }
}

/*******************************************************************************
 * Copyright 2009-2012 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License");
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Runtime Client Library
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;

namespace EasyKeys.AmazonMWS.Runtime
{
    public class MwsXmlWriter : IMwsWriter
    {
        protected XmlWriter Writer { get; set; }

        // Chars that must be escaped for XML.
        private static readonly string ESCAPED_CHARS = "&<>'\"";

        // Escape sequences for escaped chars, in order.
        private static readonly String[] ESCAPE_SEQ = new String[] { "&amp;", "&lt;", "&gt;", "&#039;", "&quot;" };

        private static readonly TypeCode[] numericTypes = { TypeCode.Double, TypeCode.Int16, TypeCode.Int32, TypeCode.Int64, TypeCode.Decimal };

        public MwsXmlWriter()
        {
        }

        public void Close()
        {
            if (Writer != null)
            {
                Writer.WriteEndDocument();
                try
                {
                    Writer.Close();
                }
                catch (Exception ex)
                {
                    throw new SystemException("Error closing the writer", ex.InnerException);
                }
            }
        }

        public void BeginObject(string name)
        {
            BeginObject(name, false);
        }

        public void EndObject(string name)
        {
            EndObject(name, false);
        }

        public void WriteList<T>(string memberName, ICollection<T> list)
        {
            if (list != null)
            {
                foreach (object elem in list)
                {
                    Write(memberName, elem);
                }
            }
        }

        public void Write(string namespc, string name, IMwsObject mwsObject)
        {
            if (mwsObject != null)
            {
                BeginObject(name, namespc, false);
                if (namespc == String.Empty)
                {
                    WriteAttribute("xmlns", namespc);
                }

                mwsObject.WriteFragmentTo(this);
                EndObject(name);
            }
        }

        public void WriteList<T>(string name, string memberName, ICollection<T> list)
        {
            if (list != null)
            {
                BeginObject(name);
                foreach (object elem in list)
                {
                    Write(memberName, elem);
                }

                EndObject(name);
            }
        }

        public void WriteAny(ICollection<XmlElement> elements)
        {
            if (elements != null)
            {
                foreach (var element in elements)
                {
                    var name = element.LocalName;
                    if (name == null)
                    {
                        name = element.Name;
                    }

                    Write(name, element);
                }
            }
        }

        public void Write(string name, object value)
        {
            if (value != null)
            {
                var type = value.GetType();
                if (Nullable.GetUnderlyingType(type) != null)
                {
                    type = Nullable.GetUnderlyingType(type);
                }

                if (typeof(string).IsAssignableFrom(type))
                {
                    BeginObject(name, false);
                    EscapeAndWrite((String)value);
                    EndObject(name, false);
                }
                else if (typeof(IConvertible).IsAssignableFrom(type))
                {
                    Writer.WriteElementString(name, (string)Convert.ChangeType(value, typeof(string), CultureInfo.InvariantCulture));
                }
                else if (typeof(IMwsObject).IsAssignableFrom(type))
                {
                    BeginObject(name, false);
                    ((IMwsObject)value).WriteFragmentTo(this);
                    EndObject(name, false);
                }
                else if (typeof(ICollection).IsAssignableFrom(type))
                {
                    foreach (var v in (ICollection)value)
                    {
                        Write(name, v);
                    }
                }
                else if (typeof(XmlNode).IsAssignableFrom(type))
                {
                    Writer.WriteRaw(((XmlNode)value).OuterXml);
                }
                else
                {
                    throw new ArgumentException("Unexpected object type: " + type);
                }
            }
        }

        public void WriteAttribute(string name, object value)
        {
            if (value != null)
            {
                BeginObject(name, true);
                EscapeAndWrite(value.ToString());
                EndObject(name, true);
            }
        }

        public void WriteValue(object value)
        {
            if (value != null)
            {
                Writer.WriteString(value.ToString());
            }
        }

        private void BeginObject(string name, bool writingAttr)
        {
            if (writingAttr)
            {
                Writer.WriteStartAttribute(name);
            }
            else
            {
                Writer.WriteStartElement(name);
            }
        }

        private void BeginObject(string name, string namespc, bool writingAttr)
        {
            if (writingAttr)
            {
                Writer.WriteStartAttribute(name);
            }
            else
            {
                Writer.WriteStartElement(name, namespc);
            }
        }

        private void EndObject(string name, bool writingAttr)
        {
            if (writingAttr)
            {
                Writer.WriteEndAttribute();
            }
            else
            {
                Writer.WriteEndElement();
            }
        }

        private void EscapeAndWrite(string value)
        {
            var n = value.Length;
            var i = 0;
            for (var j = 0; j < n; ++j)
            {
                var k = ESCAPED_CHARS.IndexOf(value[j]);
                if (k >= 0)
                {
                    if (i < j)
                    {
                        Writer.WriteChars(value.ToCharArray(), i, j - i);
                    }

                    Writer.WriteString(ESCAPE_SEQ[k]);
                    i = j + 1;
                }
            }

            if (i < n)
            {
                Writer.WriteChars(value.ToCharArray(), i, n - i);
            }
        }

        private bool IsNumeric(Type type)
        {
            return numericTypes.Contains(Type.GetTypeCode(type));
        }
    }
}

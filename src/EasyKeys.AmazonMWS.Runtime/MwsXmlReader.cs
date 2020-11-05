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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace EasyKeys.AmazonMWS.Runtime
{
    public class MwsXmlReader : IMwsReader
    {
        private readonly XmlDocument _doc;
        private XmlNode _currentElement;
        private XmlNode _currentChild;

        private readonly static TypeCode[] numericTypes = { TypeCode.Double, TypeCode.Int16, TypeCode.Int32, TypeCode.Int64 };

        /// <summary>
        /// Initializes a new instance of the <see cref="MwsXmlReader"/> class.
        /// Load the xml file and initialize. <code>current</code> and. <code>currentChild</code>
        /// </summary>
        /// <param name="xmlValue">xml content as string.</param>
        public MwsXmlReader(string xmlValue)
        {
            _doc = new XmlDocument();
            _doc.LoadXml(xmlValue);

            // initialize current node to root
            _currentElement = _doc.DocumentElement;
            _currentChild = _currentElement.FirstChild;
        }

        // methods
        public T Read<T>(string name)
        {
            var value = default(T);
            var startChild = _currentChild;
            if (_currentElement.ChildNodes.Count == 0)
            {
                return value;
            }

            do
            {
                if (_currentChild.Name.Equals(name))
                {
                    if (_currentChild is XmlAttribute)
                    {
                        value = ConvertValue<T>(_currentChild.Value);
                    }
                    else
                    {
                        value = ReadObject<T>(_currentChild);
                    }

                    _currentChild = _currentChild.NextSibling;
                    if (_currentChild == null)
                    {
                        _currentChild = _currentElement.FirstChild;
                    }

                    if (_currentChild == startChild)
                    {
                        _currentChild = startChild.NextSibling != null ? startChild.NextSibling : _currentElement.FirstChild;
                    }

                    return value;
                }

                _currentChild = _currentChild.NextSibling;
                if (_currentChild == null)
                {
                    _currentChild = _currentElement.FirstChild;
                }
            }
            while (_currentChild != startChild);
            _currentChild = startChild.NextSibling != null ? startChild.NextSibling : _currentElement.FirstChild;
            return value;
        }

        public List<T> ReadList<T>(string name)
        {
            var list = new List<T>();
            var startChild = _currentChild;
            if (_currentElement.ChildNodes.Count == 0)
            {
                return null;
            }

            do
            {
                if (_currentChild.Name.Equals(name) && _currentChild is XmlElement)
                {
                    list.Add(ReadObject<T>(_currentChild));
                }

                _currentChild = _currentChild.NextSibling;
                if (_currentChild == null)
                {
                    _currentChild = _currentElement.FirstChild;
                }
            }
            while (_currentChild != startChild);
            _currentChild = startChild.NextSibling != null ? startChild.NextSibling : _currentElement.FirstChild;
            return list;
        }

        public List<T> ReadList<T>(string name, string memberName)
        {
            var list = new List<T>();
            var startChild = _currentChild;
            if (_currentElement.ChildNodes.Count == 0)
            {
                return null;
            }

            do
            {
                if (_currentChild.Name.Equals(name) && _currentChild is XmlElement)
                {
                    BeginObject(_currentChild);
                    var innerList = ReadList<T>(memberName);
                    if (innerList != null)
                    {
                        list.AddRange(innerList);
                    }

                    EndObject();
                }

                _currentChild = _currentChild.NextSibling;
                if (_currentChild == null)
                {
                    _currentChild = _currentElement.FirstChild;
                }
            }
            while (_currentChild != startChild);
            _currentChild = startChild.NextSibling != null ? startChild.NextSibling : _currentElement.FirstChild;
            return list;
        }

        public List<XmlElement> ReadAny()
        {
            var elements = new List<XmlElement>();
            foreach (XmlNode node in _currentElement.ChildNodes)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    elements.Add((XmlElement)node);
                }
            }

            return elements;
        }

        public T ReadAttribute<T>(string name)
        {
            var node = _currentElement.Attributes[name];
            if (node != null && node.Value != null)
            {
                return ConvertValue<T>(node.Value);
            }
            else
            {
                var type = typeof(T);
                if (Nullable.GetUnderlyingType(type) != null)
                {
                    return default;
                }
                else
                {
                    throw new SystemException("Non-null Attribute \'" + name + "\' does not exist."); ;
                }
            }
        }

        public T ReadValue<T>()
        {
            if (_currentChild == null || _currentChild.NodeType != XmlNodeType.Text)
            {
                throw new SystemException("Cannot read current value");
            }
            else
            {
                return ConvertValue<T>(_currentChild.Value);
            }
        }

        private void BeginObject(XmlNode node)
        {
            if (node == null)
            {
                throw new SystemException("Cannot read null node");
            }

            // move to child node for complex object reading
            _currentElement = node;
            _currentChild = node.FirstChild;
        }

        private void EndObject()
        {
            // move the child pointer back to the parent node (BeginObject should have been called)
            _currentChild = _currentElement;
            _currentElement = _currentElement.ParentNode;
        }

        private T ConvertValue<T>(string str)
        {
            var type = typeof(T);

            if (type == typeof(string))
            {
                return (T)(object)str;
            }
            else if (type == typeof(decimal))
            {
                return (T)(object)ConvertToDecimal(str);
            }
            else if (typeof(Enum).IsAssignableFrom(type))
            {
                return (T)MwsUtil.GetEnumValue(type, str);
            }
            else if (typeof(IConvertible).IsAssignableFrom(type))
            {
                return (T)Convert.ChangeType(str, type, CultureInfo.InvariantCulture);
            }
            else if (Nullable.GetUnderlyingType(type) != null)
            {
                return ConvertNullableType<T>(str);
            }
            else
            {
                throw new InvalidDataException("Unsupported type for conversion from string: " + type.FullName);
            }
        }

        private decimal ConvertToDecimal(string str)
        {
            return Decimal.Parse(
                str,
                NumberStyles.Float,
                CultureInfo.InvariantCulture);
        }

        private T ConvertNullableType<T>(string str)
        {
            // Nullable types don't pass through Convert correctly
            if (String.IsNullOrEmpty(str))
            {
                return default;
            }
            else
            {
                var type = typeof(T);

                // First, get the type that is nullable
                var valueType = Nullable.GetUnderlyingType(type);

                // Recurse using the actual value type: ConvertValue<valueType> (must use reflection since we are generic)
                var recursiveMethod = GetType().GetMethod("ConvertValue", BindingFlags.NonPublic | BindingFlags.Instance);
                var value = recursiveMethod.MakeGenericMethod(valueType).Invoke(this, new object[] { str });

                // Return a new Nullable<valueType> (which is T) using the value we converted
                return (T)Activator.CreateInstance(type, new object[] { value });
            }
        }

        /// <summary>
        /// Read element value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node">XmlNode to be read from.</param>
        /// <returns>Value of element.</returns>
        private T ReadObject<T>(XmlNode node)
        {
            var type = typeof(T);

            if (typeof(IMwsObject).IsAssignableFrom(type))
            {
                var mwsObject = MwsUtil.NewInstance<T>();
                BeginObject(node);
                (mwsObject as IMwsObject).ReadFragmentFrom(this);
                EndObject();
                return mwsObject;
            }
            else if (type == typeof(object))
            {
                return (T)(object)node;
            }
            else
            {
                return ConvertValue<T>(node.InnerText);
            }
        }

        private bool IsNumberType(Type type)
        {
            return numericTypes.Contains(Type.GetTypeCode(type));
        }
    }
}

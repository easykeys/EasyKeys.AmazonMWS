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
using System.Text;
using System.Xml;

namespace EasyKeys.AmazonMWS.Runtime
{
    public class MwsXmlBuilder : MwsXmlWriter
    {
        private readonly StringBuilder _builder;

        public MwsXmlBuilder(bool toWrap)
        {
            _builder = new StringBuilder();
            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = !toWrap;
            Writer = XmlWriter.Create(_builder, settings);
        }

        public MwsXmlBuilder() : this(false)
        {
        }

        public MwsXmlBuilder(bool toWrap, ConformanceLevel conformanceLevel)
        {
            _builder = new StringBuilder();
            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = !toWrap;
            settings.ConformanceLevel = conformanceLevel;
            Writer = XmlWriter.Create(_builder, settings);
        }

        public override string ToString()
        {
            Writer.Flush();
            return _builder.ToString(0, _builder.Length);
        }
    }
}

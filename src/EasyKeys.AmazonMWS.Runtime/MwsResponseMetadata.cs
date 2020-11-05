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
using System.Collections.Generic;

namespace EasyKeys.AmazonMWS.Runtime
{
    /// <summary>
    /// Wrapped response metadata.
    /// </summary>
    public class MwsResponseMetadata : AbstractMwsObject
    {
        public string RequestId;
        public List<string> ResponseContext;
        public string Timestamp;

        private readonly string _name = "ResponseMetadata";

        public MwsResponseMetadata()
        {
        }

        public MwsResponseMetadata(string requestId)
        {
            RequestId = requestId;
        }

        public override void ReadFragmentFrom(IMwsReader r)
        {
            RequestId = r.Read<string>("RequestId");
        }

        public override void WriteFragmentTo(IMwsWriter w)
        {
            w.Write("RequestId", RequestId);
        }

        public override void WriteTo(IMwsWriter w)
        {
            w.BeginObject(_name);
            WriteFragmentTo(w);
            w.EndObject(_name);
        }
    }
}

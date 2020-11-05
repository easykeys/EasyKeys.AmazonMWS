/******************************************************************************* 
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * 
 */

using System;
using System.Text;

namespace MarketplaceWebService.Model
{
    public class ResponseHeaderMetadata
    {
        private string _requestId;
        private string _responseContext;
        private string _timestamp;

        public ResponseHeaderMetadata()
        {
            _requestId = _responseContext = _timestamp = null;
        }

        public ResponseHeaderMetadata(string requestId, string responseContext, string timestamp)
        {
            _requestId = requestId;
            _responseContext = responseContext;
            _timestamp = timestamp;
        }

        public string RequestId
        {
            get { return _requestId; }
        }

        public string ResponseContext
        {
            get { return _responseContext; }
        }

        public string Timestamp
        {
            get { return _timestamp; }
        }

        public override string ToString()
        {
            return "[RequestId: " + _requestId + ", ResponseContext: " + _responseContext + ", Timestamp: " + _timestamp + "]";
        }
    }
}

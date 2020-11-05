/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License");
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * List Orders Response
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class ListOrdersResponse : AbstractMwsObject, IMWSResponse
    {
        /// <summary>
        /// Gets and sets the ListOrdersResult property.
        /// </summary>
        public ListOrdersResult ListOrdersResult { get; set; }

        /// <summary>
        /// Sets the ListOrdersResult property.
        /// </summary>
        /// <param name="listOrdersResult">ListOrdersResult property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersResponse WithListOrdersResult(ListOrdersResult listOrdersResult)
        {
            ListOrdersResult = listOrdersResult;
            return this;
        }

        /// <summary>
        /// Checks if ListOrdersResult property is set.
        /// </summary>
        /// <returns>true if ListOrdersResult property is set.</returns>
        public bool IsSetListOrdersResult()
        {
            return ListOrdersResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        public ResponseMetadata ResponseMetadata { get; set; }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            ResponseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return ResponseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        public ResponseHeaderMetadata ResponseHeaderMetadata { get; set; }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            ResponseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return ResponseHeaderMetadata != null;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            ListOrdersResult = reader.Read<ListOrdersResult>("ListOrdersResult");
            ResponseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ListOrdersResult", ListOrdersResult);
            writer.Write("ResponseMetadata", ResponseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "ListOrdersResponse", this);
        }

        public ListOrdersResponse() : base()
        {
        }
    }
}

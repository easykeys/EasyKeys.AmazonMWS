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
 * Get Service Status Request
 * API Version: com.amazon.maws.coral
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class GetServiceStatusRequest : AbstractMwsObject
    {
        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        public string SellerId { get; set; }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public GetServiceStatusRequest WithSellerId(string sellerId)
        {
            SellerId = sellerId;
            return this;
        }

        /// <summary>
        /// Checks if SellerId property is set.
        /// </summary>
        /// <returns>true if SellerId property is set.</returns>
        public bool IsSetSellerId()
        {
            return SellerId != null;
        }

        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        public string MWSAuthToken { get; set; }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public GetServiceStatusRequest WithMWSAuthToken(string mwsAuthToken)
        {
            MWSAuthToken = mwsAuthToken;
            return this;
        }

        /// <summary>
        /// Checks if MWSAuthToken property is set.
        /// </summary>
        /// <returns>true if MWSAuthToken property is set.</returns>
        public bool IsSetMWSAuthToken()
        {
            return MWSAuthToken != null;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            SellerId = reader.Read<string>("SellerId");
            MWSAuthToken = reader.Read<string>("MWSAuthToken");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", SellerId);
            writer.Write("MWSAuthToken", MWSAuthToken);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://internal.amazon.com/coral/com.amazon.maws.coral/", "GetServiceStatusRequest", this);
        }

        public GetServiceStatusRequest() : base()
        {
        }
    }
}

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
 * List Order Items By Next Token Result
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using System.Collections.Generic;

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class ListOrderItemsByNextTokenResult : AbstractMwsObject
    {
        private List<OrderItem> _orderItems;

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsByNextTokenResult WithNextToken(string nextToken)
        {
            NextToken = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set.</returns>
        public bool IsSetNextToken()
        {
            return NextToken != null;
        }

        /// <summary>
        /// Gets and sets the AmazonOrderId property.
        /// </summary>
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// Sets the AmazonOrderId property.
        /// </summary>
        /// <param name="amazonOrderId">AmazonOrderId property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsByNextTokenResult WithAmazonOrderId(string amazonOrderId)
        {
            AmazonOrderId = amazonOrderId;
            return this;
        }

        /// <summary>
        /// Checks if AmazonOrderId property is set.
        /// </summary>
        /// <returns>true if AmazonOrderId property is set.</returns>
        public bool IsSetAmazonOrderId()
        {
            return AmazonOrderId != null;
        }

        /// <summary>
        /// Gets and sets the OrderItems property.
        /// </summary>
        public List<OrderItem> OrderItems
        {
            get => _orderItems ??= new List<OrderItem>();

            set => _orderItems = value;
        }

        /// <summary>
        /// Sets the OrderItems property.
        /// </summary>
        /// <param name="orderItems">OrderItems property.</param>
        /// <returns>this instance.</returns>
        public ListOrderItemsByNextTokenResult WithOrderItems(OrderItem[] orderItems)
        {
            _orderItems.AddRange(orderItems);
            return this;
        }

        /// <summary>
        /// Checks if OrderItems property is set.
        /// </summary>
        /// <returns>true if OrderItems property is set.</returns>
        public bool IsSetOrderItems()
        {
            return OrderItems.Count > 0;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            NextToken = reader.Read<string>("NextToken");
            AmazonOrderId = reader.Read<string>("AmazonOrderId");
            _orderItems = reader.ReadList<OrderItem>("OrderItems", "OrderItem");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NextToken", NextToken);
            writer.Write("AmazonOrderId", AmazonOrderId);
            writer.WriteList("OrderItems", "OrderItem", _orderItems);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "ListOrderItemsByNextTokenResult", this);
        }

        public ListOrderItemsByNextTokenResult() : base()
        {
        }
    }
}

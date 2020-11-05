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
 * List Orders By Next Token Result
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using System;
using System.Collections.Generic;

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class ListOrdersByNextTokenResult : AbstractMwsObject
    {
        private DateTime? _createdBefore;
        private DateTime? _lastUpdatedBefore;
        private List<Order> _orders;

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersByNextTokenResult WithNextToken(string nextToken)
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
        /// Gets and sets the CreatedBefore property.
        /// </summary>
        public DateTime CreatedBefore
        {
            get => _createdBefore.GetValueOrDefault();
            set => _createdBefore = value;
        }

        /// <summary>
        /// Sets the CreatedBefore property.
        /// </summary>
        /// <param name="createdBefore">CreatedBefore property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersByNextTokenResult WithCreatedBefore(DateTime createdBefore)
        {
            _createdBefore = createdBefore;
            return this;
        }

        /// <summary>
        /// Checks if CreatedBefore property is set.
        /// </summary>
        /// <returns>true if CreatedBefore property is set.</returns>
        public bool IsSetCreatedBefore()
        {
            return _createdBefore != null;
        }

        /// <summary>
        /// Gets and sets the LastUpdatedBefore property.
        /// </summary>
        public DateTime LastUpdatedBefore
        {
            get => _lastUpdatedBefore.GetValueOrDefault();
            set => _lastUpdatedBefore = value;
        }

        /// <summary>
        /// Sets the LastUpdatedBefore property.
        /// </summary>
        /// <param name="lastUpdatedBefore">LastUpdatedBefore property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersByNextTokenResult WithLastUpdatedBefore(DateTime lastUpdatedBefore)
        {
            _lastUpdatedBefore = lastUpdatedBefore;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdatedBefore property is set.
        /// </summary>
        /// <returns>true if LastUpdatedBefore property is set.</returns>
        public bool IsSetLastUpdatedBefore()
        {
            return _lastUpdatedBefore != null;
        }

        /// <summary>
        /// Gets and sets the Orders property.
        /// </summary>
        public List<Order> Orders
        {
            get => _orders ??= new List<Order>();

            set => _orders = value;
        }

        /// <summary>
        /// Sets the Orders property.
        /// </summary>
        /// <param name="orders">Orders property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersByNextTokenResult WithOrders(Order[] orders)
        {
            _orders.AddRange(orders);
            return this;
        }

        /// <summary>
        /// Checks if Orders property is set.
        /// </summary>
        /// <returns>true if Orders property is set.</returns>
        public bool IsSetOrders()
        {
            return Orders.Count > 0;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            NextToken = reader.Read<string>("NextToken");
            _createdBefore = reader.Read<DateTime?>("CreatedBefore");
            _lastUpdatedBefore = reader.Read<DateTime?>("LastUpdatedBefore");
            _orders = reader.ReadList<Order>("Orders", "Order");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NextToken", NextToken);
            writer.Write("CreatedBefore", _createdBefore);
            writer.Write("LastUpdatedBefore", _lastUpdatedBefore);
            writer.WriteList("Orders", "Order", _orders);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "ListOrdersByNextTokenResult", this);
        }

        public ListOrdersByNextTokenResult() : base()
        {
        }
    }
}

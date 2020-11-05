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
 * List Orders Request
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using System;
using System.Collections.Generic;

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class ListOrdersRequest : AbstractMwsObject
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private DateTime? _lastUpdatedAfter;
        private DateTime? _lastUpdatedBefore;
        private List<string> _orderStatus;
        private List<string> _marketplaceId;
        private List<string> _fulfillmentChannel;
        private List<string> _paymentMethod;
        private decimal? _maxResultsPerPage;
        private List<string> _tfmShipmentStatus;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        public string SellerId { get; set; }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithSellerId(string sellerId)
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
        public ListOrdersRequest WithMWSAuthToken(string mwsAuthToken)
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

        /// <summary>
        /// Gets and sets the CreatedAfter property.
        /// </summary>
        public DateTime CreatedAfter
        {
            get => _createdAfter.GetValueOrDefault();
            set => _createdAfter = value;
        }

        /// <summary>
        /// Sets the CreatedAfter property.
        /// </summary>
        /// <param name="createdAfter">CreatedAfter property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithCreatedAfter(DateTime createdAfter)
        {
            _createdAfter = createdAfter;
            return this;
        }

        /// <summary>
        /// Checks if CreatedAfter property is set.
        /// </summary>
        /// <returns>true if CreatedAfter property is set.</returns>
        public bool IsSetCreatedAfter()
        {
            return _createdAfter != null;
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
        public ListOrdersRequest WithCreatedBefore(DateTime createdBefore)
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
        /// Gets and sets the LastUpdatedAfter property.
        /// </summary>
        public DateTime LastUpdatedAfter
        {
            get => _lastUpdatedAfter.GetValueOrDefault();
            set => _lastUpdatedAfter = value;
        }

        /// <summary>
        /// Sets the LastUpdatedAfter property.
        /// </summary>
        /// <param name="lastUpdatedAfter">LastUpdatedAfter property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithLastUpdatedAfter(DateTime lastUpdatedAfter)
        {
            _lastUpdatedAfter = lastUpdatedAfter;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdatedAfter property is set.
        /// </summary>
        /// <returns>true if LastUpdatedAfter property is set.</returns>
        public bool IsSetLastUpdatedAfter()
        {
            return _lastUpdatedAfter != null;
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
        public ListOrdersRequest WithLastUpdatedBefore(DateTime lastUpdatedBefore)
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
        /// Gets and sets the OrderStatus property.
        /// </summary>
        public List<string> OrderStatus
        {
            get => _orderStatus ??= new List<string>();

            set => _orderStatus = value;
        }

        /// <summary>
        /// Sets the OrderStatus property.
        /// </summary>
        /// <param name="orderStatus">OrderStatus property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithOrderStatus(string[] orderStatus)
        {
            _orderStatus.AddRange(orderStatus);
            return this;
        }

        /// <summary>
        /// Checks if OrderStatus property is set.
        /// </summary>
        /// <returns>true if OrderStatus property is set.</returns>
        public bool IsSetOrderStatus()
        {
            return OrderStatus.Count > 0;
        }

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        public List<string> MarketplaceId
        {
            get => _marketplaceId ??= new List<string>();

            set => _marketplaceId = value;
        }

        /// <summary>
        /// Sets the MarketplaceId property.
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithMarketplaceId(string[] marketplaceId)
        {
            _marketplaceId.AddRange(marketplaceId);
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceId property is set.
        /// </summary>
        /// <returns>true if MarketplaceId property is set.</returns>
        public bool IsSetMarketplaceId()
        {
            return MarketplaceId.Count > 0;
        }

        /// <summary>
        /// Gets and sets the FulfillmentChannel property.
        /// </summary>
        public List<string> FulfillmentChannel
        {
            get => _fulfillmentChannel ??= new List<string>();

            set => _fulfillmentChannel = value;
        }

        /// <summary>
        /// Sets the FulfillmentChannel property.
        /// </summary>
        /// <param name="fulfillmentChannel">FulfillmentChannel property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithFulfillmentChannel(string[] fulfillmentChannel)
        {
            _fulfillmentChannel.AddRange(fulfillmentChannel);
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentChannel property is set.
        /// </summary>
        /// <returns>true if FulfillmentChannel property is set.</returns>
        public bool IsSetFulfillmentChannel()
        {
            return FulfillmentChannel.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PaymentMethod property.
        /// </summary>
        public List<string> PaymentMethod
        {
            get => _paymentMethod ??= new List<string>();

            set => _paymentMethod = value;
        }

        /// <summary>
        /// Sets the PaymentMethod property.
        /// </summary>
        /// <param name="paymentMethod">PaymentMethod property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithPaymentMethod(string[] paymentMethod)
        {
            _paymentMethod.AddRange(paymentMethod);
            return this;
        }

        /// <summary>
        /// Checks if PaymentMethod property is set.
        /// </summary>
        /// <returns>true if PaymentMethod property is set.</returns>
        public bool IsSetPaymentMethod()
        {
            return PaymentMethod.Count > 0;
        }

        /// <summary>
        /// Gets and sets the BuyerEmail property.
        /// </summary>
        public string BuyerEmail { get; set; }

        /// <summary>
        /// Sets the BuyerEmail property.
        /// </summary>
        /// <param name="buyerEmail">BuyerEmail property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithBuyerEmail(string buyerEmail)
        {
            BuyerEmail = buyerEmail;
            return this;
        }

        /// <summary>
        /// Checks if BuyerEmail property is set.
        /// </summary>
        /// <returns>true if BuyerEmail property is set.</returns>
        public bool IsSetBuyerEmail()
        {
            return BuyerEmail != null;
        }

        /// <summary>
        /// Gets and sets the SellerOrderId property.
        /// </summary>
        public string SellerOrderId { get; set; }

        /// <summary>
        /// Sets the SellerOrderId property.
        /// </summary>
        /// <param name="sellerOrderId">SellerOrderId property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithSellerOrderId(string sellerOrderId)
        {
            SellerOrderId = sellerOrderId;
            return this;
        }

        /// <summary>
        /// Checks if SellerOrderId property is set.
        /// </summary>
        /// <returns>true if SellerOrderId property is set.</returns>
        public bool IsSetSellerOrderId()
        {
            return SellerOrderId != null;
        }

        /// <summary>
        /// Gets and sets the MaxResultsPerPage property.
        /// </summary>
        public decimal MaxResultsPerPage
        {
            get => _maxResultsPerPage.GetValueOrDefault();
            set => _maxResultsPerPage = value;
        }

        /// <summary>
        /// Sets the MaxResultsPerPage property.
        /// </summary>
        /// <param name="maxResultsPerPage">MaxResultsPerPage property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithMaxResultsPerPage(decimal maxResultsPerPage)
        {
            _maxResultsPerPage = maxResultsPerPage;
            return this;
        }

        /// <summary>
        /// Checks if MaxResultsPerPage property is set.
        /// </summary>
        /// <returns>true if MaxResultsPerPage property is set.</returns>
        public bool IsSetMaxResultsPerPage()
        {
            return _maxResultsPerPage != null;
        }

        /// <summary>
        /// Gets and sets the TFMShipmentStatus property.
        /// </summary>
        public List<string> TFMShipmentStatus
        {
            get => _tfmShipmentStatus ??= new List<string>();

            set => _tfmShipmentStatus = value;
        }

        /// <summary>
        /// Sets the TFMShipmentStatus property.
        /// </summary>
        /// <param name="tfmShipmentStatus">TFMShipmentStatus property.</param>
        /// <returns>this instance.</returns>
        public ListOrdersRequest WithTFMShipmentStatus(string[] tfmShipmentStatus)
        {
            _tfmShipmentStatus.AddRange(tfmShipmentStatus);
            return this;
        }

        /// <summary>
        /// Checks if TFMShipmentStatus property is set.
        /// </summary>
        /// <returns>true if TFMShipmentStatus property is set.</returns>
        public bool IsSetTFMShipmentStatus()
        {
            return TFMShipmentStatus.Count > 0;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            SellerId = reader.Read<string>("SellerId");
            MWSAuthToken = reader.Read<string>("MWSAuthToken");
            _createdAfter = reader.Read<DateTime?>("CreatedAfter");
            _createdBefore = reader.Read<DateTime?>("CreatedBefore");
            _lastUpdatedAfter = reader.Read<DateTime?>("LastUpdatedAfter");
            _lastUpdatedBefore = reader.Read<DateTime?>("LastUpdatedBefore");
            _orderStatus = reader.ReadList<string>("OrderStatus", "Status");
            _marketplaceId = reader.ReadList<string>("MarketplaceId", "Id");
            _fulfillmentChannel = reader.ReadList<string>("FulfillmentChannel", "Channel");
            _paymentMethod = reader.ReadList<string>("PaymentMethod", "Method");
            BuyerEmail = reader.Read<string>("BuyerEmail");
            SellerOrderId = reader.Read<string>("SellerOrderId");
            _maxResultsPerPage = reader.Read<decimal?>("MaxResultsPerPage");
            _tfmShipmentStatus = reader.ReadList<string>("TFMShipmentStatus", "Status");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", SellerId);
            writer.Write("MWSAuthToken", MWSAuthToken);
            writer.Write("CreatedAfter", _createdAfter);
            writer.Write("CreatedBefore", _createdBefore);
            writer.Write("LastUpdatedAfter", _lastUpdatedAfter);
            writer.Write("LastUpdatedBefore", _lastUpdatedBefore);
            writer.WriteList("OrderStatus", "Status", _orderStatus);
            writer.WriteList("MarketplaceId", "Id", _marketplaceId);
            writer.WriteList("FulfillmentChannel", "Channel", _fulfillmentChannel);
            writer.WriteList("PaymentMethod", "Method", _paymentMethod);
            writer.Write("BuyerEmail", BuyerEmail);
            writer.Write("SellerOrderId", SellerOrderId);
            writer.Write("MaxResultsPerPage", _maxResultsPerPage);
            writer.WriteList("TFMShipmentStatus", "Status", _tfmShipmentStatus);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "ListOrdersRequest", this);
        }

        public ListOrdersRequest() : base()
        {
        }
    }
}

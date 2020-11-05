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
 * Order
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using System;
using System.Collections.Generic;

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class Order : AbstractMwsObject
    {
        private DateTime? _purchaseDate;
        private DateTime? _lastUpdateDate;
        private decimal? _numberOfItemsShipped;
        private decimal? _numberOfItemsUnshipped;
        private List<PaymentExecutionDetailItem> _paymentExecutionDetail;
        private bool? _shippedByAmazonTFM;
        private DateTime? _earliestShipDate;
        private DateTime? _latestShipDate;
        private DateTime? _earliestDeliveryDate;
        private DateTime? _latestDeliveryDate;
        private bool? _isBusinessOrder;
        private bool? _isPrime;
        private bool? _isPremiumOrder;

        /// <summary>
        /// Gets and sets the AmazonOrderId property.
        /// </summary>
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// Sets the AmazonOrderId property.
        /// </summary>
        /// <param name="amazonOrderId">AmazonOrderId property.</param>
        /// <returns>this instance.</returns>
        public Order WithAmazonOrderId(string amazonOrderId)
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
        /// Gets and sets the SellerOrderId property.
        /// </summary>
        public string SellerOrderId { get; set; }

        /// <summary>
        /// Sets the SellerOrderId property.
        /// </summary>
        /// <param name="sellerOrderId">SellerOrderId property.</param>
        /// <returns>this instance.</returns>
        public Order WithSellerOrderId(string sellerOrderId)
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
        /// Gets and sets the PurchaseDate property.
        /// </summary>
        public DateTime PurchaseDate
        {
            get => _purchaseDate.GetValueOrDefault();
            set => _purchaseDate = value;
        }

        /// <summary>
        /// Sets the PurchaseDate property.
        /// </summary>
        /// <param name="purchaseDate">PurchaseDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithPurchaseDate(DateTime purchaseDate)
        {
            _purchaseDate = purchaseDate;
            return this;
        }

        /// <summary>
        /// Checks if PurchaseDate property is set.
        /// </summary>
        /// <returns>true if PurchaseDate property is set.</returns>
        public bool IsSetPurchaseDate()
        {
            return _purchaseDate != null;
        }

        /// <summary>
        /// Gets and sets the LastUpdateDate property.
        /// </summary>
        public DateTime LastUpdateDate
        {
            get => _lastUpdateDate.GetValueOrDefault();
            set => _lastUpdateDate = value;
        }

        /// <summary>
        /// Sets the LastUpdateDate property.
        /// </summary>
        /// <param name="lastUpdateDate">LastUpdateDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithLastUpdateDate(DateTime lastUpdateDate)
        {
            _lastUpdateDate = lastUpdateDate;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdateDate property is set.
        /// </summary>
        /// <returns>true if LastUpdateDate property is set.</returns>
        public bool IsSetLastUpdateDate()
        {
            return _lastUpdateDate != null;
        }

        /// <summary>
        /// Gets and sets the OrderStatus property.
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        /// Sets the OrderStatus property.
        /// </summary>
        /// <param name="orderStatus">OrderStatus property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderStatus(string orderStatus)
        {
            OrderStatus = orderStatus;
            return this;
        }

        /// <summary>
        /// Checks if OrderStatus property is set.
        /// </summary>
        /// <returns>true if OrderStatus property is set.</returns>
        public bool IsSetOrderStatus()
        {
            return OrderStatus != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentChannel property.
        /// </summary>
        public string FulfillmentChannel { get; set; }

        /// <summary>
        /// Sets the FulfillmentChannel property.
        /// </summary>
        /// <param name="fulfillmentChannel">FulfillmentChannel property.</param>
        /// <returns>this instance.</returns>
        public Order WithFulfillmentChannel(string fulfillmentChannel)
        {
            FulfillmentChannel = fulfillmentChannel;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentChannel property is set.
        /// </summary>
        /// <returns>true if FulfillmentChannel property is set.</returns>
        public bool IsSetFulfillmentChannel()
        {
            return FulfillmentChannel != null;
        }

        /// <summary>
        /// Gets and sets the SalesChannel property.
        /// </summary>
        public string SalesChannel { get; set; }

        /// <summary>
        /// Sets the SalesChannel property.
        /// </summary>
        /// <param name="salesChannel">SalesChannel property.</param>
        /// <returns>this instance.</returns>
        public Order WithSalesChannel(string salesChannel)
        {
            SalesChannel = salesChannel;
            return this;
        }

        /// <summary>
        /// Checks if SalesChannel property is set.
        /// </summary>
        /// <returns>true if SalesChannel property is set.</returns>
        public bool IsSetSalesChannel()
        {
            return SalesChannel != null;
        }

        /// <summary>
        /// Gets and sets the OrderChannel property.
        /// </summary>
        public string OrderChannel { get; set; }

        /// <summary>
        /// Sets the OrderChannel property.
        /// </summary>
        /// <param name="orderChannel">OrderChannel property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderChannel(string orderChannel)
        {
            OrderChannel = orderChannel;
            return this;
        }

        /// <summary>
        /// Checks if OrderChannel property is set.
        /// </summary>
        /// <returns>true if OrderChannel property is set.</returns>
        public bool IsSetOrderChannel()
        {
            return OrderChannel != null;
        }

        /// <summary>
        /// Gets and sets the ShipServiceLevel property.
        /// </summary>
        public string ShipServiceLevel { get; set; }

        /// <summary>
        /// Sets the ShipServiceLevel property.
        /// </summary>
        /// <param name="shipServiceLevel">ShipServiceLevel property.</param>
        /// <returns>this instance.</returns>
        public Order WithShipServiceLevel(string shipServiceLevel)
        {
            ShipServiceLevel = shipServiceLevel;
            return this;
        }

        /// <summary>
        /// Checks if ShipServiceLevel property is set.
        /// </summary>
        /// <returns>true if ShipServiceLevel property is set.</returns>
        public bool IsSetShipServiceLevel()
        {
            return ShipServiceLevel != null;
        }

        /// <summary>
        /// Gets and sets the ShippingAddress property.
        /// </summary>
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Sets the ShippingAddress property.
        /// </summary>
        /// <param name="shippingAddress">ShippingAddress property.</param>
        /// <returns>this instance.</returns>
        public Order WithShippingAddress(Address shippingAddress)
        {
            ShippingAddress = shippingAddress;
            return this;
        }

        /// <summary>
        /// Checks if ShippingAddress property is set.
        /// </summary>
        /// <returns>true if ShippingAddress property is set.</returns>
        public bool IsSetShippingAddress()
        {
            return ShippingAddress != null;
        }

        /// <summary>
        /// Gets and sets the OrderTotal property.
        /// </summary>
        public Money OrderTotal { get; set; }

        /// <summary>
        /// Sets the OrderTotal property.
        /// </summary>
        /// <param name="orderTotal">OrderTotal property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderTotal(Money orderTotal)
        {
            OrderTotal = orderTotal;
            return this;
        }

        /// <summary>
        /// Checks if OrderTotal property is set.
        /// </summary>
        /// <returns>true if OrderTotal property is set.</returns>
        public bool IsSetOrderTotal()
        {
            return OrderTotal != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfItemsShipped property.
        /// </summary>
        public decimal NumberOfItemsShipped
        {
            get => _numberOfItemsShipped.GetValueOrDefault();
            set => _numberOfItemsShipped = value;
        }

        /// <summary>
        /// Sets the NumberOfItemsShipped property.
        /// </summary>
        /// <param name="numberOfItemsShipped">NumberOfItemsShipped property.</param>
        /// <returns>this instance.</returns>
        public Order WithNumberOfItemsShipped(decimal numberOfItemsShipped)
        {
            _numberOfItemsShipped = numberOfItemsShipped;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfItemsShipped property is set.
        /// </summary>
        /// <returns>true if NumberOfItemsShipped property is set.</returns>
        public bool IsSetNumberOfItemsShipped()
        {
            return _numberOfItemsShipped != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfItemsUnshipped property.
        /// </summary>
        public decimal NumberOfItemsUnshipped
        {
            get => _numberOfItemsUnshipped.GetValueOrDefault();
            set => _numberOfItemsUnshipped = value;
        }

        /// <summary>
        /// Sets the NumberOfItemsUnshipped property.
        /// </summary>
        /// <param name="numberOfItemsUnshipped">NumberOfItemsUnshipped property.</param>
        /// <returns>this instance.</returns>
        public Order WithNumberOfItemsUnshipped(decimal numberOfItemsUnshipped)
        {
            _numberOfItemsUnshipped = numberOfItemsUnshipped;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfItemsUnshipped property is set.
        /// </summary>
        /// <returns>true if NumberOfItemsUnshipped property is set.</returns>
        public bool IsSetNumberOfItemsUnshipped()
        {
            return _numberOfItemsUnshipped != null;
        }

        /// <summary>
        /// Gets and sets the PaymentExecutionDetail property.
        /// </summary>
        public List<PaymentExecutionDetailItem> PaymentExecutionDetail
        {
            get => _paymentExecutionDetail ??= new List<PaymentExecutionDetailItem>();

            set => _paymentExecutionDetail = value;
        }

        /// <summary>
        /// Sets the PaymentExecutionDetail property.
        /// </summary>
        /// <param name="paymentExecutionDetail">PaymentExecutionDetail property.</param>
        /// <returns>this instance.</returns>
        public Order WithPaymentExecutionDetail(PaymentExecutionDetailItem[] paymentExecutionDetail)
        {
            _paymentExecutionDetail.AddRange(paymentExecutionDetail);
            return this;
        }

        /// <summary>
        /// Checks if PaymentExecutionDetail property is set.
        /// </summary>
        /// <returns>true if PaymentExecutionDetail property is set.</returns>
        public bool IsSetPaymentExecutionDetail()
        {
            return PaymentExecutionDetail.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PaymentMethod property.
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Sets the PaymentMethod property.
        /// </summary>
        /// <param name="paymentMethod">PaymentMethod property.</param>
        /// <returns>this instance.</returns>
        public Order WithPaymentMethod(string paymentMethod)
        {
            PaymentMethod = paymentMethod;
            return this;
        }

        /// <summary>
        /// Checks if PaymentMethod property is set.
        /// </summary>
        /// <returns>true if PaymentMethod property is set.</returns>
        public bool IsSetPaymentMethod()
        {
            return PaymentMethod != null;
        }

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Sets the MarketplaceId property.
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property.</param>
        /// <returns>this instance.</returns>
        public Order WithMarketplaceId(string marketplaceId)
        {
            MarketplaceId = marketplaceId;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceId property is set.
        /// </summary>
        /// <returns>true if MarketplaceId property is set.</returns>
        public bool IsSetMarketplaceId()
        {
            return MarketplaceId != null;
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
        public Order WithBuyerEmail(string buyerEmail)
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
        /// Gets and sets the BuyerName property.
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// Sets the BuyerName property.
        /// </summary>
        /// <param name="buyerName">BuyerName property.</param>
        /// <returns>this instance.</returns>
        public Order WithBuyerName(string buyerName)
        {
            BuyerName = buyerName;
            return this;
        }

        /// <summary>
        /// Checks if BuyerName property is set.
        /// </summary>
        /// <returns>true if BuyerName property is set.</returns>
        public bool IsSetBuyerName()
        {
            return BuyerName != null;
        }

        /// <summary>
        /// Gets and sets the ShipmentServiceLevelCategory property.
        /// </summary>
        public string ShipmentServiceLevelCategory { get; set; }

        /// <summary>
        /// Sets the ShipmentServiceLevelCategory property.
        /// </summary>
        /// <param name="shipmentServiceLevelCategory">ShipmentServiceLevelCategory property.</param>
        /// <returns>this instance.</returns>
        public Order WithShipmentServiceLevelCategory(string shipmentServiceLevelCategory)
        {
            ShipmentServiceLevelCategory = shipmentServiceLevelCategory;
            return this;
        }

        /// <summary>
        /// Checks if ShipmentServiceLevelCategory property is set.
        /// </summary>
        /// <returns>true if ShipmentServiceLevelCategory property is set.</returns>
        public bool IsSetShipmentServiceLevelCategory()
        {
            return ShipmentServiceLevelCategory != null;
        }

        /// <summary>
        /// Gets and sets the ShippedByAmazonTFM property.
        /// </summary>
        public bool ShippedByAmazonTFM
        {
            get => _shippedByAmazonTFM.GetValueOrDefault();
            set => _shippedByAmazonTFM = value;
        }

        /// <summary>
        /// Sets the ShippedByAmazonTFM property.
        /// </summary>
        /// <param name="shippedByAmazonTFM">ShippedByAmazonTFM property.</param>
        /// <returns>this instance.</returns>
        public Order WithShippedByAmazonTFM(bool shippedByAmazonTFM)
        {
            _shippedByAmazonTFM = shippedByAmazonTFM;
            return this;
        }

        /// <summary>
        /// Checks if ShippedByAmazonTFM property is set.
        /// </summary>
        /// <returns>true if ShippedByAmazonTFM property is set.</returns>
        public bool IsSetShippedByAmazonTFM()
        {
            return _shippedByAmazonTFM != null;
        }

        /// <summary>
        /// Gets and sets the TFMShipmentStatus property.
        /// </summary>
        public string TFMShipmentStatus { get; set; }

        /// <summary>
        /// Sets the TFMShipmentStatus property.
        /// </summary>
        /// <param name="tfmShipmentStatus">TFMShipmentStatus property.</param>
        /// <returns>this instance.</returns>
        public Order WithTFMShipmentStatus(string tfmShipmentStatus)
        {
            TFMShipmentStatus = tfmShipmentStatus;
            return this;
        }

        /// <summary>
        /// Checks if TFMShipmentStatus property is set.
        /// </summary>
        /// <returns>true if TFMShipmentStatus property is set.</returns>
        public bool IsSetTFMShipmentStatus()
        {
            return TFMShipmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the CbaDisplayableShippingLabel property.
        /// </summary>
        public string CbaDisplayableShippingLabel { get; set; }

        /// <summary>
        /// Sets the CbaDisplayableShippingLabel property.
        /// </summary>
        /// <param name="cbaDisplayableShippingLabel">CbaDisplayableShippingLabel property.</param>
        /// <returns>this instance.</returns>
        public Order WithCbaDisplayableShippingLabel(string cbaDisplayableShippingLabel)
        {
            CbaDisplayableShippingLabel = cbaDisplayableShippingLabel;
            return this;
        }

        /// <summary>
        /// Checks if CbaDisplayableShippingLabel property is set.
        /// </summary>
        /// <returns>true if CbaDisplayableShippingLabel property is set.</returns>
        public bool IsSetCbaDisplayableShippingLabel()
        {
            return CbaDisplayableShippingLabel != null;
        }

        /// <summary>
        /// Gets and sets the OrderType property.
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// Sets the OrderType property.
        /// </summary>
        /// <param name="orderType">OrderType property.</param>
        /// <returns>this instance.</returns>
        public Order WithOrderType(string orderType)
        {
            OrderType = orderType;
            return this;
        }

        /// <summary>
        /// Checks if OrderType property is set.
        /// </summary>
        /// <returns>true if OrderType property is set.</returns>
        public bool IsSetOrderType()
        {
            return OrderType != null;
        }

        /// <summary>
        /// Gets and sets the EarliestShipDate property.
        /// </summary>
        public DateTime EarliestShipDate
        {
            get => _earliestShipDate.GetValueOrDefault();
            set => _earliestShipDate = value;
        }

        /// <summary>
        /// Sets the EarliestShipDate property.
        /// </summary>
        /// <param name="earliestShipDate">EarliestShipDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithEarliestShipDate(DateTime earliestShipDate)
        {
            _earliestShipDate = earliestShipDate;
            return this;
        }

        /// <summary>
        /// Checks if EarliestShipDate property is set.
        /// </summary>
        /// <returns>true if EarliestShipDate property is set.</returns>
        public bool IsSetEarliestShipDate()
        {
            return _earliestShipDate != null;
        }

        /// <summary>
        /// Gets and sets the LatestShipDate property.
        /// </summary>
        public DateTime LatestShipDate
        {
            get => _latestShipDate.GetValueOrDefault();
            set => _latestShipDate = value;
        }

        /// <summary>
        /// Sets the LatestShipDate property.
        /// </summary>
        /// <param name="latestShipDate">LatestShipDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithLatestShipDate(DateTime latestShipDate)
        {
            _latestShipDate = latestShipDate;
            return this;
        }

        /// <summary>
        /// Checks if LatestShipDate property is set.
        /// </summary>
        /// <returns>true if LatestShipDate property is set.</returns>
        public bool IsSetLatestShipDate()
        {
            return _latestShipDate != null;
        }

        /// <summary>
        /// Gets and sets the EarliestDeliveryDate property.
        /// </summary>
        public DateTime EarliestDeliveryDate
        {
            get => _earliestDeliveryDate.GetValueOrDefault();
            set => _earliestDeliveryDate = value;
        }

        /// <summary>
        /// Sets the EarliestDeliveryDate property.
        /// </summary>
        /// <param name="earliestDeliveryDate">EarliestDeliveryDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithEarliestDeliveryDate(DateTime earliestDeliveryDate)
        {
            _earliestDeliveryDate = earliestDeliveryDate;
            return this;
        }

        /// <summary>
        /// Checks if EarliestDeliveryDate property is set.
        /// </summary>
        /// <returns>true if EarliestDeliveryDate property is set.</returns>
        public bool IsSetEarliestDeliveryDate()
        {
            return _earliestDeliveryDate != null;
        }

        /// <summary>
        /// Gets and sets the LatestDeliveryDate property.
        /// </summary>
        public DateTime LatestDeliveryDate
        {
            get => _latestDeliveryDate.GetValueOrDefault();
            set => _latestDeliveryDate = value;
        }

        /// <summary>
        /// Sets the LatestDeliveryDate property.
        /// </summary>
        /// <param name="latestDeliveryDate">LatestDeliveryDate property.</param>
        /// <returns>this instance.</returns>
        public Order WithLatestDeliveryDate(DateTime latestDeliveryDate)
        {
            _latestDeliveryDate = latestDeliveryDate;
            return this;
        }

        /// <summary>
        /// Checks if LatestDeliveryDate property is set.
        /// </summary>
        /// <returns>true if LatestDeliveryDate property is set.</returns>
        public bool IsSetLatestDeliveryDate()
        {
            return _latestDeliveryDate != null;
        }

        /// <summary>
        /// Gets and sets the IsBusinessOrder property.
        /// </summary>
        public bool IsBusinessOrder
        {
            get => _isBusinessOrder.GetValueOrDefault();
            set => _isBusinessOrder = value;
        }

        /// <summary>
        /// Sets the IsBusinessOrder property.
        /// </summary>
        /// <param name="isBusinessOrder">IsBusinessOrder property.</param>
        /// <returns>this instance.</returns>
        public Order WithIsBusinessOrder(bool isBusinessOrder)
        {
            _isBusinessOrder = isBusinessOrder;
            return this;
        }

        /// <summary>
        /// Checks if IsBusinessOrder property is set.
        /// </summary>
        /// <returns>true if IsBusinessOrder property is set.</returns>
        public bool IsSetIsBusinessOrder()
        {
            return _isBusinessOrder != null;
        }

        /// <summary>
        /// Gets and sets the PurchaseOrderNumber property.
        /// </summary>
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Sets the PurchaseOrderNumber property.
        /// </summary>
        /// <param name="purchaseOrderNumber">PurchaseOrderNumber property.</param>
        /// <returns>this instance.</returns>
        public Order WithPurchaseOrderNumber(string purchaseOrderNumber)
        {
            PurchaseOrderNumber = purchaseOrderNumber;
            return this;
        }

        /// <summary>
        /// Checks if PurchaseOrderNumber property is set.
        /// </summary>
        /// <returns>true if PurchaseOrderNumber property is set.</returns>
        public bool IsSetPurchaseOrderNumber()
        {
            return PurchaseOrderNumber != null;
        }

        /// <summary>
        /// Gets and sets the IsPrime property.
        /// </summary>
        public bool IsPrime
        {
            get => _isPrime.GetValueOrDefault();
            set => _isPrime = value;
        }

        /// <summary>
        /// Sets the IsPrime property.
        /// </summary>
        /// <param name="isPrime">IsPrime property.</param>
        /// <returns>this instance.</returns>
        public Order WithIsPrime(bool isPrime)
        {
            _isPrime = isPrime;
            return this;
        }

        /// <summary>
        /// Checks if IsPrime property is set.
        /// </summary>
        /// <returns>true if IsPrime property is set.</returns>
        public bool IsSetIsPrime()
        {
            return _isPrime != null;
        }

        /// <summary>
        /// Gets and sets the IsPremiumOrder property.
        /// </summary>
        public bool IsPremiumOrder
        {
            get => _isPremiumOrder.GetValueOrDefault();
            set => _isPremiumOrder = value;
        }

        /// <summary>
        /// Sets the IsPremiumOrder property.
        /// </summary>
        /// <param name="isPremiumOrder">IsPremiumOrder property.</param>
        /// <returns>this instance.</returns>
        public Order WithIsPremiumOrder(bool isPremiumOrder)
        {
            _isPremiumOrder = isPremiumOrder;
            return this;
        }

        /// <summary>
        /// Checks if IsPremiumOrder property is set.
        /// </summary>
        /// <returns>true if IsPremiumOrder property is set.</returns>
        public bool IsSetIsPremiumOrder()
        {
            return _isPremiumOrder != null;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            AmazonOrderId = reader.Read<string>("AmazonOrderId");
            SellerOrderId = reader.Read<string>("SellerOrderId");
            _purchaseDate = reader.Read<DateTime?>("PurchaseDate");
            _lastUpdateDate = reader.Read<DateTime?>("LastUpdateDate");
            OrderStatus = reader.Read<string>("OrderStatus");
            FulfillmentChannel = reader.Read<string>("FulfillmentChannel");
            SalesChannel = reader.Read<string>("SalesChannel");
            OrderChannel = reader.Read<string>("OrderChannel");
            ShipServiceLevel = reader.Read<string>("ShipServiceLevel");
            ShippingAddress = reader.Read<Address>("ShippingAddress");
            OrderTotal = reader.Read<Money>("OrderTotal");
            _numberOfItemsShipped = reader.Read<decimal?>("NumberOfItemsShipped");
            _numberOfItemsUnshipped = reader.Read<decimal?>("NumberOfItemsUnshipped");
            _paymentExecutionDetail = reader.ReadList<PaymentExecutionDetailItem>("PaymentExecutionDetail", "PaymentExecutionDetailItem");
            PaymentMethod = reader.Read<string>("PaymentMethod");
            MarketplaceId = reader.Read<string>("MarketplaceId");
            BuyerEmail = reader.Read<string>("BuyerEmail");
            BuyerName = reader.Read<string>("BuyerName");
            ShipmentServiceLevelCategory = reader.Read<string>("ShipmentServiceLevelCategory");
            _shippedByAmazonTFM = reader.Read<bool?>("ShippedByAmazonTFM");
            TFMShipmentStatus = reader.Read<string>("TFMShipmentStatus");
            CbaDisplayableShippingLabel = reader.Read<string>("CbaDisplayableShippingLabel");
            OrderType = reader.Read<string>("OrderType");
            _earliestShipDate = reader.Read<DateTime?>("EarliestShipDate");
            _latestShipDate = reader.Read<DateTime?>("LatestShipDate");
            _earliestDeliveryDate = reader.Read<DateTime?>("EarliestDeliveryDate");
            _latestDeliveryDate = reader.Read<DateTime?>("LatestDeliveryDate");
            _isBusinessOrder = reader.Read<bool?>("IsBusinessOrder");
            PurchaseOrderNumber = reader.Read<string>("PurchaseOrderNumber");
            _isPrime = reader.Read<bool?>("IsPrime");
            _isPremiumOrder = reader.Read<bool?>("IsPremiumOrder");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("AmazonOrderId", AmazonOrderId);
            writer.Write("SellerOrderId", SellerOrderId);
            writer.Write("PurchaseDate", _purchaseDate);
            writer.Write("LastUpdateDate", _lastUpdateDate);
            writer.Write("OrderStatus", OrderStatus);
            writer.Write("FulfillmentChannel", FulfillmentChannel);
            writer.Write("SalesChannel", SalesChannel);
            writer.Write("OrderChannel", OrderChannel);
            writer.Write("ShipServiceLevel", ShipServiceLevel);
            writer.Write("ShippingAddress", ShippingAddress);
            writer.Write("OrderTotal", OrderTotal);
            writer.Write("NumberOfItemsShipped", _numberOfItemsShipped);
            writer.Write("NumberOfItemsUnshipped", _numberOfItemsUnshipped);
            writer.WriteList("PaymentExecutionDetail", "PaymentExecutionDetailItem", _paymentExecutionDetail);
            writer.Write("PaymentMethod", PaymentMethod);
            writer.Write("MarketplaceId", MarketplaceId);
            writer.Write("BuyerEmail", BuyerEmail);
            writer.Write("BuyerName", BuyerName);
            writer.Write("ShipmentServiceLevelCategory", ShipmentServiceLevelCategory);
            writer.Write("ShippedByAmazonTFM", _shippedByAmazonTFM);
            writer.Write("TFMShipmentStatus", TFMShipmentStatus);
            writer.Write("CbaDisplayableShippingLabel", CbaDisplayableShippingLabel);
            writer.Write("OrderType", OrderType);
            writer.Write("EarliestShipDate", _earliestShipDate);
            writer.Write("LatestShipDate", _latestShipDate);
            writer.Write("EarliestDeliveryDate", _earliestDeliveryDate);
            writer.Write("LatestDeliveryDate", _latestDeliveryDate);
            writer.Write("IsBusinessOrder", _isBusinessOrder);
            writer.Write("PurchaseOrderNumber", PurchaseOrderNumber);
            writer.Write("IsPrime", _isPrime);
            writer.Write("IsPremiumOrder", _isPremiumOrder);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "Order", this);
        }

        public Order() : base()
        {
        }
    }
}

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
 * Order Item
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using System.Collections.Generic;

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class OrderItem : AbstractMwsObject
    {
        private decimal? _quantityShipped;
        private List<string> _promotionIds;
        private string _priceDesignation;

        /// <summary>
        /// Gets and sets the ASIN property.
        /// </summary>
        public string ASIN { get; set; }

        /// <summary>
        /// Sets the ASIN property.
        /// </summary>
        /// <param name="asin">ASIN property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithASIN(string asin)
        {
            ASIN = asin;
            return this;
        }

        /// <summary>
        /// Checks if ASIN property is set.
        /// </summary>
        /// <returns>true if ASIN property is set.</returns>
        public bool IsSetASIN()
        {
            return ASIN != null;
        }

        /// <summary>
        /// Gets and sets the SellerSKU property.
        /// </summary>
        public string SellerSKU { get; set; }

        /// <summary>
        /// Sets the SellerSKU property.
        /// </summary>
        /// <param name="sellerSKU">SellerSKU property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithSellerSKU(string sellerSKU)
        {
            SellerSKU = sellerSKU;
            return this;
        }

        /// <summary>
        /// Checks if SellerSKU property is set.
        /// </summary>
        /// <returns>true if SellerSKU property is set.</returns>
        public bool IsSetSellerSKU()
        {
            return SellerSKU != null;
        }

        /// <summary>
        /// Gets and sets the OrderItemId property.
        /// </summary>
        public string OrderItemId { get; set; }

        /// <summary>
        /// Sets the OrderItemId property.
        /// </summary>
        /// <param name="orderItemId">OrderItemId property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithOrderItemId(string orderItemId)
        {
            OrderItemId = orderItemId;
            return this;
        }

        /// <summary>
        /// Checks if OrderItemId property is set.
        /// </summary>
        /// <returns>true if OrderItemId property is set.</returns>
        public bool IsSetOrderItemId()
        {
            return OrderItemId != null;
        }

        /// <summary>
        /// Gets and sets the Title property.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Sets the Title property.
        /// </summary>
        /// <param name="title">Title property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithTitle(string title)
        {
            Title = title;
            return this;
        }

        /// <summary>
        /// Checks if Title property is set.
        /// </summary>
        /// <returns>true if Title property is set.</returns>
        public bool IsSetTitle()
        {
            return Title != null;
        }

        /// <summary>
        /// Gets and sets the QuantityOrdered property.
        /// </summary>
        public decimal QuantityOrdered { get; set; }

        /// <summary>
        /// Sets the QuantityOrdered property.
        /// </summary>
        /// <param name="quantityOrdered">QuantityOrdered property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithQuantityOrdered(decimal quantityOrdered)
        {
            QuantityOrdered = quantityOrdered;
            return this;
        }

        /// <summary>
        /// Checks if QuantityOrdered property is set.
        /// </summary>
        /// <returns>true if QuantityOrdered property is set.</returns>
        public bool IsSetQuantityOrdered()
        {
            return QuantityOrdered != null;
        }

        /// <summary>
        /// Gets and sets the QuantityShipped property.
        /// </summary>
        public decimal QuantityShipped
        {
            get => _quantityShipped.GetValueOrDefault();
            set => _quantityShipped = value;
        }

        /// <summary>
        /// Sets the QuantityShipped property.
        /// </summary>
        /// <param name="quantityShipped">QuantityShipped property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithQuantityShipped(decimal quantityShipped)
        {
            _quantityShipped = quantityShipped;
            return this;
        }

        /// <summary>
        /// Checks if QuantityShipped property is set.
        /// </summary>
        /// <returns>true if QuantityShipped property is set.</returns>
        public bool IsSetQuantityShipped()
        {
            return _quantityShipped != null;
        }

        /// <summary>
        /// Gets and sets the PointsGranted property.
        /// </summary>
        public PointsGrantedDetail PointsGranted { get; set; }

        /// <summary>
        /// Sets the PointsGranted property.
        /// </summary>
        /// <param name="pointsGranted">PointsGranted property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPointsGranted(PointsGrantedDetail pointsGranted)
        {
            PointsGranted = pointsGranted;
            return this;
        }

        /// <summary>
        /// Checks if PointsGranted property is set.
        /// </summary>
        /// <returns>true if PointsGranted property is set.</returns>
        public bool IsSetPointsGranted()
        {
            return PointsGranted != null;
        }

        /// <summary>
        /// Gets and sets the ItemPrice property.
        /// </summary>
        public Money ItemPrice { get; set; }

        /// <summary>
        /// Sets the ItemPrice property.
        /// </summary>
        /// <param name="itemPrice">ItemPrice property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithItemPrice(Money itemPrice)
        {
            ItemPrice = itemPrice;
            return this;
        }

        /// <summary>
        /// Checks if ItemPrice property is set.
        /// </summary>
        /// <returns>true if ItemPrice property is set.</returns>
        public bool IsSetItemPrice()
        {
            return ItemPrice != null;
        }

        /// <summary>
        /// Gets and sets the ShippingPrice property.
        /// </summary>
        public Money ShippingPrice { get; set; }

        /// <summary>
        /// Sets the ShippingPrice property.
        /// </summary>
        /// <param name="shippingPrice">ShippingPrice property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithShippingPrice(Money shippingPrice)
        {
            ShippingPrice = shippingPrice;
            return this;
        }

        /// <summary>
        /// Checks if ShippingPrice property is set.
        /// </summary>
        /// <returns>true if ShippingPrice property is set.</returns>
        public bool IsSetShippingPrice()
        {
            return ShippingPrice != null;
        }

        /// <summary>
        /// Gets and sets the GiftWrapPrice property.
        /// </summary>
        public Money GiftWrapPrice { get; set; }

        /// <summary>
        /// Sets the GiftWrapPrice property.
        /// </summary>
        /// <param name="giftWrapPrice">GiftWrapPrice property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftWrapPrice(Money giftWrapPrice)
        {
            GiftWrapPrice = giftWrapPrice;
            return this;
        }

        /// <summary>
        /// Checks if GiftWrapPrice property is set.
        /// </summary>
        /// <returns>true if GiftWrapPrice property is set.</returns>
        public bool IsSetGiftWrapPrice()
        {
            return GiftWrapPrice != null;
        }

        /// <summary>
        /// Gets and sets the ItemTax property.
        /// </summary>
        public Money ItemTax { get; set; }

        /// <summary>
        /// Sets the ItemTax property.
        /// </summary>
        /// <param name="itemTax">ItemTax property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithItemTax(Money itemTax)
        {
            ItemTax = itemTax;
            return this;
        }

        /// <summary>
        /// Checks if ItemTax property is set.
        /// </summary>
        /// <returns>true if ItemTax property is set.</returns>
        public bool IsSetItemTax()
        {
            return ItemTax != null;
        }

        /// <summary>
        /// Gets and sets the ShippingTax property.
        /// </summary>
        public Money ShippingTax { get; set; }

        /// <summary>
        /// Sets the ShippingTax property.
        /// </summary>
        /// <param name="shippingTax">ShippingTax property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithShippingTax(Money shippingTax)
        {
            ShippingTax = shippingTax;
            return this;
        }

        /// <summary>
        /// Checks if ShippingTax property is set.
        /// </summary>
        /// <returns>true if ShippingTax property is set.</returns>
        public bool IsSetShippingTax()
        {
            return ShippingTax != null;
        }

        /// <summary>
        /// Gets and sets the GiftWrapTax property.
        /// </summary>
        public Money GiftWrapTax { get; set; }

        /// <summary>
        /// Sets the GiftWrapTax property.
        /// </summary>
        /// <param name="giftWrapTax">GiftWrapTax property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftWrapTax(Money giftWrapTax)
        {
            GiftWrapTax = giftWrapTax;
            return this;
        }

        /// <summary>
        /// Checks if GiftWrapTax property is set.
        /// </summary>
        /// <returns>true if GiftWrapTax property is set.</returns>
        public bool IsSetGiftWrapTax()
        {
            return GiftWrapTax != null;
        }

        /// <summary>
        /// Gets and sets the ShippingDiscount property.
        /// </summary>
        public Money ShippingDiscount { get; set; }

        /// <summary>
        /// Sets the ShippingDiscount property.
        /// </summary>
        /// <param name="shippingDiscount">ShippingDiscount property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithShippingDiscount(Money shippingDiscount)
        {
            ShippingDiscount = shippingDiscount;
            return this;
        }

        /// <summary>
        /// Checks if ShippingDiscount property is set.
        /// </summary>
        /// <returns>true if ShippingDiscount property is set.</returns>
        public bool IsSetShippingDiscount()
        {
            return ShippingDiscount != null;
        }

        /// <summary>
        /// Gets and sets the PromotionDiscount property.
        /// </summary>
        public Money PromotionDiscount { get; set; }

        /// <summary>
        /// Sets the PromotionDiscount property.
        /// </summary>
        /// <param name="promotionDiscount">PromotionDiscount property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPromotionDiscount(Money promotionDiscount)
        {
            PromotionDiscount = promotionDiscount;
            return this;
        }

        /// <summary>
        /// Checks if PromotionDiscount property is set.
        /// </summary>
        /// <returns>true if PromotionDiscount property is set.</returns>
        public bool IsSetPromotionDiscount()
        {
            return PromotionDiscount != null;
        }

        /// <summary>
        /// Gets and sets the PromotionIds property.
        /// </summary>
        public List<string> PromotionIds
        {
            get => _promotionIds ??= new List<string>();

            set => _promotionIds = value;
        }

        /// <summary>
        /// Sets the PromotionIds property.
        /// </summary>
        /// <param name="promotionIds">PromotionIds property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPromotionIds(string[] promotionIds)
        {
            _promotionIds.AddRange(promotionIds);
            return this;
        }

        /// <summary>
        /// Checks if PromotionIds property is set.
        /// </summary>
        /// <returns>true if PromotionIds property is set.</returns>
        public bool IsSetPromotionIds()
        {
            return PromotionIds.Count > 0;
        }

        /// <summary>
        /// Gets and sets the CODFee property.
        /// </summary>
        public Money CODFee { get; set; }

        /// <summary>
        /// Sets the CODFee property.
        /// </summary>
        /// <param name="codFee">CODFee property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithCODFee(Money codFee)
        {
            CODFee = codFee;
            return this;
        }

        /// <summary>
        /// Checks if CODFee property is set.
        /// </summary>
        /// <returns>true if CODFee property is set.</returns>
        public bool IsSetCODFee()
        {
            return CODFee != null;
        }

        /// <summary>
        /// Gets and sets the CODFeeDiscount property.
        /// </summary>
        public Money CODFeeDiscount { get; set; }

        /// <summary>
        /// Sets the CODFeeDiscount property.
        /// </summary>
        /// <param name="codFeeDiscount">CODFeeDiscount property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithCODFeeDiscount(Money codFeeDiscount)
        {
            CODFeeDiscount = codFeeDiscount;
            return this;
        }

        /// <summary>
        /// Checks if CODFeeDiscount property is set.
        /// </summary>
        /// <returns>true if CODFeeDiscount property is set.</returns>
        public bool IsSetCODFeeDiscount()
        {
            return CODFeeDiscount != null;
        }

        /// <summary>
        /// Gets and sets the GiftMessageText property.
        /// </summary>
        public string GiftMessageText { get; set; }

        /// <summary>
        /// Sets the GiftMessageText property.
        /// </summary>
        /// <param name="giftMessageText">GiftMessageText property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftMessageText(string giftMessageText)
        {
            GiftMessageText = giftMessageText;
            return this;
        }

        /// <summary>
        /// Checks if GiftMessageText property is set.
        /// </summary>
        /// <returns>true if GiftMessageText property is set.</returns>
        public bool IsSetGiftMessageText()
        {
            return GiftMessageText != null;
        }

        /// <summary>
        /// Gets and sets the GiftWrapLevel property.
        /// </summary>
        public string GiftWrapLevel { get; set; }

        /// <summary>
        /// Sets the GiftWrapLevel property.
        /// </summary>
        /// <param name="giftWrapLevel">GiftWrapLevel property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithGiftWrapLevel(string giftWrapLevel)
        {
            GiftWrapLevel = giftWrapLevel;
            return this;
        }

        /// <summary>
        /// Checks if GiftWrapLevel property is set.
        /// </summary>
        /// <returns>true if GiftWrapLevel property is set.</returns>
        public bool IsSetGiftWrapLevel()
        {
            return GiftWrapLevel != null;
        }

        /// <summary>
        /// Gets and sets the InvoiceData property.
        /// </summary>
        public InvoiceData InvoiceData { get; set; }

        /// <summary>
        /// Sets the InvoiceData property.
        /// </summary>
        /// <param name="invoiceData">InvoiceData property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithInvoiceData(InvoiceData invoiceData)
        {
            InvoiceData = invoiceData;
            return this;
        }

        /// <summary>
        /// Checks if InvoiceData property is set.
        /// </summary>
        /// <returns>true if InvoiceData property is set.</returns>
        public bool IsSetInvoiceData()
        {
            return InvoiceData != null;
        }

        /// <summary>
        /// Gets and sets the ConditionNote property.
        /// </summary>
        public string ConditionNote { get; set; }

        /// <summary>
        /// Sets the ConditionNote property.
        /// </summary>
        /// <param name="conditionNote">ConditionNote property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithConditionNote(string conditionNote)
        {
            ConditionNote = conditionNote;
            return this;
        }

        /// <summary>
        /// Checks if ConditionNote property is set.
        /// </summary>
        /// <returns>true if ConditionNote property is set.</returns>
        public bool IsSetConditionNote()
        {
            return ConditionNote != null;
        }

        /// <summary>
        /// Gets and sets the ConditionId property.
        /// </summary>
        public string ConditionId { get; set; }

        /// <summary>
        /// Sets the ConditionId property.
        /// </summary>
        /// <param name="conditionId">ConditionId property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithConditionId(string conditionId)
        {
            ConditionId = conditionId;
            return this;
        }

        /// <summary>
        /// Checks if ConditionId property is set.
        /// </summary>
        /// <returns>true if ConditionId property is set.</returns>
        public bool IsSetConditionId()
        {
            return ConditionId != null;
        }

        /// <summary>
        /// Gets and sets the ConditionSubtypeId property.
        /// </summary>
        public string ConditionSubtypeId { get; set; }

        /// <summary>
        /// Sets the ConditionSubtypeId property.
        /// </summary>
        /// <param name="conditionSubtypeId">ConditionSubtypeId property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithConditionSubtypeId(string conditionSubtypeId)
        {
            ConditionSubtypeId = conditionSubtypeId;
            return this;
        }

        /// <summary>
        /// Checks if ConditionSubtypeId property is set.
        /// </summary>
        /// <returns>true if ConditionSubtypeId property is set.</returns>
        public bool IsSetConditionSubtypeId()
        {
            return ConditionSubtypeId != null;
        }

        /// <summary>
        /// Gets and sets the ScheduledDeliveryStartDate property.
        /// </summary>
        public string ScheduledDeliveryStartDate { get; set; }

        /// <summary>
        /// Sets the ScheduledDeliveryStartDate property.
        /// </summary>
        /// <param name="scheduledDeliveryStartDate">ScheduledDeliveryStartDate property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithScheduledDeliveryStartDate(string scheduledDeliveryStartDate)
        {
            ScheduledDeliveryStartDate = scheduledDeliveryStartDate;
            return this;
        }

        /// <summary>
        /// Checks if ScheduledDeliveryStartDate property is set.
        /// </summary>
        /// <returns>true if ScheduledDeliveryStartDate property is set.</returns>
        public bool IsSetScheduledDeliveryStartDate()
        {
            return ScheduledDeliveryStartDate != null;
        }

        /// <summary>
        /// Gets and sets the ScheduledDeliveryEndDate property.
        /// </summary>
        public string ScheduledDeliveryEndDate { get; set; }

        /// <summary>
        /// Sets the ScheduledDeliveryEndDate property.
        /// </summary>
        /// <param name="scheduledDeliveryEndDate">ScheduledDeliveryEndDate property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithScheduledDeliveryEndDate(string scheduledDeliveryEndDate)
        {
            ScheduledDeliveryEndDate = scheduledDeliveryEndDate;
            return this;
        }

        /// <summary>
        /// Checks if ScheduledDeliveryEndDate property is set.
        /// </summary>
        /// <returns>true if ScheduledDeliveryEndDate property is set.</returns>
        public bool IsSetScheduledDeliveryEndDate()
        {
            return ScheduledDeliveryEndDate != null;
        }

        /// <summary>
        /// Gets and sets the PriceDesignation property.
        /// </summary>
        public string PriceDesignation
        {
            get => _priceDesignation;
            set => _priceDesignation = value;
        }

        /// <summary>
        /// Sets the PriceDesignation property.
        /// </summary>
        /// <param name="priceDesignation">PriceDesignation property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithPriceDesignation(string priceDesignation)
        {
            _priceDesignation = priceDesignation;
            return this;
        }

        /// <summary>
        /// Checks if PriceDesignation property is set.
        /// </summary>
        /// <returns>true if PriceDesignation property is set.</returns>
        public bool IsSetPriceDesignation()
        {
            return _priceDesignation != null;
        }

        /// <summary>
        /// Gets and sets the BuyerCustomizedInfo property.
        /// </summary>
        public BuyerCustomizedInfoDetail BuyerCustomizedInfo { get; set; }

        /// <summary>
        /// Sets the BuyerCustomizedInfo property.
        /// </summary>
        /// <param name="buyerCustomizedInfo">BuyerCustomizedInfo property.</param>
        /// <returns>this instance.</returns>
        public OrderItem WithBuyerCustomizedInfo(BuyerCustomizedInfoDetail buyerCustomizedInfo)
        {
            BuyerCustomizedInfo = buyerCustomizedInfo;
            return this;
        }

        /// <summary>
        /// Checks if BuyerCustomizedInfo property is set.
        /// </summary>
        /// <returns>true if BuyerCustomizedInfo property is set.</returns>
        public bool IsSetBuyerCustomizedInfo()
        {
            return BuyerCustomizedInfo != null;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            ASIN = reader.Read<string>("ASIN");
            SellerSKU = reader.Read<string>("SellerSKU");
            OrderItemId = reader.Read<string>("OrderItemId");
            Title = reader.Read<string>("Title");
            QuantityOrdered = reader.Read<decimal>("QuantityOrdered");
            _quantityShipped = reader.Read<decimal?>("QuantityShipped");
            PointsGranted = reader.Read<PointsGrantedDetail>("PointsGranted");
            ItemPrice = reader.Read<Money>("ItemPrice");
            ShippingPrice = reader.Read<Money>("ShippingPrice");
            GiftWrapPrice = reader.Read<Money>("GiftWrapPrice");
            ItemTax = reader.Read<Money>("ItemTax");
            ShippingTax = reader.Read<Money>("ShippingTax");
            GiftWrapTax = reader.Read<Money>("GiftWrapTax");
            ShippingDiscount = reader.Read<Money>("ShippingDiscount");
            PromotionDiscount = reader.Read<Money>("PromotionDiscount");
            _promotionIds = reader.ReadList<string>("PromotionIds", "PromotionId");
            CODFee = reader.Read<Money>("CODFee");
            CODFeeDiscount = reader.Read<Money>("CODFeeDiscount");
            GiftMessageText = reader.Read<string>("GiftMessageText");
            GiftWrapLevel = reader.Read<string>("GiftWrapLevel");
            InvoiceData = reader.Read<InvoiceData>("InvoiceData");
            ConditionNote = reader.Read<string>("ConditionNote");
            ConditionId = reader.Read<string>("ConditionId");
            ConditionSubtypeId = reader.Read<string>("ConditionSubtypeId");
            ScheduledDeliveryStartDate = reader.Read<string>("ScheduledDeliveryStartDate");
            ScheduledDeliveryEndDate = reader.Read<string>("ScheduledDeliveryEndDate");
            _priceDesignation = reader.Read<string>("PriceDesignation");
            BuyerCustomizedInfo = reader.Read<BuyerCustomizedInfoDetail>("BuyerCustomizedInfo");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ASIN", ASIN);
            writer.Write("SellerSKU", SellerSKU);
            writer.Write("OrderItemId", OrderItemId);
            writer.Write("Title", Title);
            writer.Write("QuantityOrdered", QuantityOrdered);
            writer.Write("QuantityShipped", _quantityShipped);
            writer.Write("PointsGranted", PointsGranted);
            writer.Write("ItemPrice", ItemPrice);
            writer.Write("ShippingPrice", ShippingPrice);
            writer.Write("GiftWrapPrice", GiftWrapPrice);
            writer.Write("ItemTax", ItemTax);
            writer.Write("ShippingTax", ShippingTax);
            writer.Write("GiftWrapTax", GiftWrapTax);
            writer.Write("ShippingDiscount", ShippingDiscount);
            writer.Write("PromotionDiscount", PromotionDiscount);
            writer.WriteList("PromotionIds", "PromotionId", _promotionIds);
            writer.Write("CODFee", CODFee);
            writer.Write("CODFeeDiscount", CODFeeDiscount);
            writer.Write("GiftMessageText", GiftMessageText);
            writer.Write("GiftWrapLevel", GiftWrapLevel);
            writer.Write("InvoiceData", InvoiceData);
            writer.Write("ConditionNote", ConditionNote);
            writer.Write("ConditionId", ConditionId);
            writer.Write("ConditionSubtypeId", ConditionSubtypeId);
            writer.Write("ScheduledDeliveryStartDate", ScheduledDeliveryStartDate);
            writer.Write("ScheduledDeliveryEndDate", ScheduledDeliveryEndDate);
            writer.Write("PriceDesignation", _priceDesignation);
            writer.Write("BuyerCustomizedInfo", BuyerCustomizedInfo);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "OrderItem", this);
        }

        public OrderItem() : base()
        {
        }
    }
}

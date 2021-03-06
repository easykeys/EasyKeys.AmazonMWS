/*******************************************************************************
 *  Copyright 2009 Amazon Services.
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
 *  Generated: Mon Mar 16 17:31:42 PDT 2009
 *
 */

using System;
using System.Xml.Serialization;

using EasyKeys.AmazonMWS.Feeds.Attributes;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    [MarketplaceWebServiceAttribute(RequestType = RequestType.DEFAULT, ResponseType = ResponseType.DEFAULT)]
    public class GetFeedSubmissionListRequest
    {
        private DateTime? _submittedFromDateField;

        private DateTime? _submittedToDateField;

        /// <summary>
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElement(ElementName = "Marketplace")]
        [Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public string Marketplace { get; set; }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        [Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public GetFeedSubmissionListRequest WithMarketplace(string marketplace)
        {
            Marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        [Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public bool IsSetMarketplace()
        {
            return Marketplace != null;
        }

        /// <summary>
        /// Gets and sets the Merchant property.
        /// </summary>
        [XmlElement(ElementName = "Merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// Sets the Merchant property.
        /// </summary>
        /// <param name="merchant">Merchant property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithMerchant(string merchant)
        {
            Merchant = merchant;
            return this;
        }

        /// <summary>
        /// Checks if Merchant property is set.
        /// </summary>
        /// <returns>true if Merchant property is set.</returns>
        public bool IsSetMerchant()
        {
            return Merchant != null;
        }

        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElement(ElementName = "MWSAuthToken")]
        public string MWSAuthToken { get; set; }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the FeedSubmissionIdList property.
        /// </summary>
        [XmlElement(ElementName = "FeedSubmissionIdList")]
        public IdList FeedSubmissionIdList { get; set; }

        /// <summary>
        /// Sets the FeedSubmissionIdList property.
        /// </summary>
        /// <param name="feedSubmissionIdList">FeedSubmissionIdList property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithFeedSubmissionIdList(IdList feedSubmissionIdList)
        {
            FeedSubmissionIdList = feedSubmissionIdList;
            return this;
        }

        /// <summary>
        /// Checks if FeedSubmissionIdList property is set.
        /// </summary>
        /// <returns>true if FeedSubmissionIdList property is set.</returns>
        public bool IsSetFeedSubmissionIdList()
        {
            return FeedSubmissionIdList != null;
        }

        /// <summary>
        /// Gets and sets the MaxCount property.
        /// </summary>
        [XmlElement(ElementName = "MaxCount")]
        public decimal? MaxCount { get; set; }

        /// <summary>
        /// Sets the MaxCount property.
        /// </summary>
        /// <param name="maxCount">MaxCount property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithMaxCount(int? maxCount)
        {
            MaxCount = maxCount;
            return this;
        }

        /// <summary>
        /// Checks if MaxCount property is set.
        /// </summary>
        /// <returns>true if MaxCount property is set.</returns>
        public bool IsSetMaxCount()
        {
            return MaxCount != null;
        }

        /// <summary>
        /// Gets and sets the FeedTypeList property.
        /// </summary>
        [XmlElement(ElementName = "FeedTypeList")]
        public TypeList FeedTypeList { get; set; }

        /// <summary>
        /// Sets the FeedTypeList property.
        /// </summary>
        /// <param name="feedTypeList">FeedTypeList property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithFeedTypeList(TypeList feedTypeList)
        {
            FeedTypeList = feedTypeList;
            return this;
        }

        /// <summary>
        /// Checks if FeedTypeList property is set.
        /// </summary>
        /// <returns>true if FeedTypeList property is set.</returns>
        public bool IsSetFeedTypeList()
        {
            return FeedTypeList != null;
        }

        /// <summary>
        /// Gets and sets the FeedProcessingStatusList property.
        /// </summary>
        [XmlElement(ElementName = "FeedProcessingStatusList")]
        public StatusList FeedProcessingStatusList { get; set; }

        /// <summary>
        /// Sets the FeedProcessingStatusList property.
        /// </summary>
        /// <param name="feedProcessingStatusList">FeedProcessingStatusList property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithFeedProcessingStatusList(StatusList feedProcessingStatusList)
        {
            FeedProcessingStatusList = feedProcessingStatusList;
            return this;
        }

        /// <summary>
        /// Checks if FeedProcessingStatusList property is set.
        /// </summary>
        /// <returns>true if FeedProcessingStatusList property is set.</returns>
        public bool IsSetFeedProcessingStatusList()
        {
            return FeedProcessingStatusList != null;
        }

        /// <summary>
        /// Gets and sets the SubmittedFromDate property.
        /// </summary>
        [XmlElement(ElementName = "SubmittedFromDate")]
        public DateTime SubmittedFromDate
        {
            get => _submittedFromDateField.GetValueOrDefault();
            set => _submittedFromDateField = value;
        }

        /// <summary>
        /// Sets the SubmittedFromDate property.
        /// </summary>
        /// <param name="submittedFromDate">SubmittedFromDate property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithSubmittedFromDate(DateTime submittedFromDate)
        {
            _submittedFromDateField = submittedFromDate;
            return this;
        }

        /// <summary>
        /// Checks if SubmittedFromDate property is set.
        /// </summary>
        /// <returns>true if SubmittedFromDate property is set.</returns>
        public bool IsSetSubmittedFromDate()
        {
            return _submittedFromDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the SubmittedToDate property.
        /// </summary>
        [XmlElement(ElementName = "SubmittedToDate")]
        public DateTime SubmittedToDate
        {
            get => _submittedToDateField.GetValueOrDefault();
            set => _submittedToDateField = value;
        }

        /// <summary>
        /// Sets the SubmittedToDate property.
        /// </summary>
        /// <param name="submittedToDate">SubmittedToDate property.</param>
        /// <returns>this instance.</returns>
        public GetFeedSubmissionListRequest WithSubmittedToDate(DateTime submittedToDate)
        {
            _submittedToDateField = submittedToDate;
            return this;
        }

        /// <summary>
        /// Checks if SubmittedToDate property is set.
        /// </summary>
        /// <returns>true if SubmittedToDate property is set.</returns>
        public bool IsSetSubmittedToDate()
        {
            return _submittedToDateField.HasValue;
        }
    }
}

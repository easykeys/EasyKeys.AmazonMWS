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

using System.IO;
using System.Xml.Serialization;

using EasyKeys.AmazonMWS.Feeds.Attributes;

namespace MarketplaceWebService.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    [MarketplaceWebService(RequestType = RequestType.STREAMING, ResponseType = ResponseType.DEFAULT)]
    public class SubmitFeedRequest
    {
        private string _merchantField;

        private bool? _purgeAndReplaceField;

        /// <summary>
        /// Gets or sets the content type.
        /// Defaults to octet-stream, with no character or content encoding.
        /// </summary>
        public ContentType ContentType { get; set; } = new ContentType(MediaType.OctetStream);

        [MarketplaceWebServiceRequestHeader("Content-MD5")]
        public string ContentMD5 { get; set; }

        public SubmitFeedRequest WithContentMD5(string contentMD5)
        {
            ContentMD5 = contentMD5;
            return this;
        }

        /// <summary>
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElement(ElementName = "Marketplace")]
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public string Marketplace { get; set; }

        /// <summary>
        /// Gets and sets the MarketplaceIdList property, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to submit a feed to.
        /// </summary>
        [XmlElement(ElementName = "MarketplaceIdList")]
        public IdList MarketplaceIdList { get; set; }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public SubmitFeedRequest WithMarketplace(string marketplace)
        {
            Marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Sets the MarketplaceIdList property, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to submit a feed to.
        /// </summary>
        /// <param name="marketplaceIdList"> MarketplaceIdList property.</param>
        /// <returns></returns>
        public SubmitFeedRequest WithMarketplaceIdList(IdList marketplaceIdList)
        {
            MarketplaceIdList = marketplaceIdList;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public bool IsSetMarketplace()
        {
            return Marketplace != null;
        }

        /// <summary>
        /// Checks if MarketplaceIdList property is set, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to submit a feed to.
        /// </summary>
        /// <returns>true if MarketplaceIdList property is set.</returns>
        public bool IsSetMarketplaceIdList()
        {
            return MarketplaceIdList != null;
        }

        /// <summary>
        /// Gets and sets the Merchant property.
        /// </summary>
        [XmlElement(ElementName = "Merchant")]
        public string Merchant
        {
            get { return _merchantField; }
            set { _merchantField = value; }
        }

        /// <summary>
        /// Sets the Merchant property.
        /// </summary>
        /// <param name="merchant">Merchant property.</param>
        /// <returns>this instance.</returns>
        public SubmitFeedRequest WithMerchant(string merchant)
        {
            _merchantField = merchant;
            return this;
        }

        /// <summary>
        /// Checks if Merchant property is set.
        /// </summary>
        /// <returns>true if Merchant property is set.</returns>
        public bool IsSetMerchant()
        {
            return _merchantField != null;
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
        public SubmitFeedRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the FeedContent property.
        /// </summary>
        [MarketplaceWebServiceStream(StreamType = StreamType.REQUEST_STREAM)]
        public Stream FeedContent { get; set; }

        /// <summary>
        /// Sets the FeedContent property.
        /// </summary>
        /// <param name="feedContent">FeedContent property.</param>
        /// <returns>this instance.</returns>
        public SubmitFeedRequest WithFeedContent(Stream feedContent)
        {
            FeedContent = feedContent;
            return this;
        }

        /// <summary>
        /// Checks if FeedContent property is set.
        /// </summary>
        /// <returns>true if FeedContent property is set.</returns>
        public bool IsSetFeedContent()
        {
            return FeedContent != null;
        }

        /// <summary>
        /// Gets and sets the FeedType property.
        /// </summary>
        [XmlElement(ElementName = "FeedType")]
        public string FeedType { get; set; }

        /// <summary>
        /// Sets the FeedType property.
        /// </summary>
        /// <param name="feedType">FeedType property.</param>
        /// <returns>this instance.</returns>
        public SubmitFeedRequest WithFeedType(string feedType)
        {
            FeedType = feedType;
            return this;
        }

        /// <summary>
        /// Checks if FeedType property is set.
        /// </summary>
        /// <returns>true if FeedType property is set.</returns>
        public bool IsSetFeedType()
        {
            return FeedType != null;
        }

        /// <summary>
        /// Gets and sets the PurgeAndReplace property.
        /// </summary>
        [XmlElement(ElementName = "PurgeAndReplace")]
        public bool PurgeAndReplace
        {
            get { return _purgeAndReplaceField.GetValueOrDefault(); }
            set { _purgeAndReplaceField = value; }
        }

        /// <summary>
        /// Sets the PurgeAndReplace property.
        /// </summary>
        /// <param name="purgeAndReplace">PurgeAndReplace property.</param>
        /// <returns>this instance.</returns>
        public SubmitFeedRequest WithPurgeAndReplace(bool purgeAndReplace)
        {
            _purgeAndReplaceField = purgeAndReplace;
            return this;
        }

        /// <summary>
        /// Checks if PurgeAndReplace property is set.
        /// </summary>
        /// <returns>true if PurgeAndReplace property is set.</returns>
        public bool IsSetPurgeAndReplace()
        {
            return _purgeAndReplaceField.HasValue;
        }
    }
}

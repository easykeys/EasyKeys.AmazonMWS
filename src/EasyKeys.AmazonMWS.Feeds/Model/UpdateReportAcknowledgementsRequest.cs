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

using System.Xml.Serialization;

using EasyKeys.AmazonMWS.Feeds.Attributes;

namespace MarketplaceWebService.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    [MarketplaceWebService(RequestType = RequestType.DEFAULT, ResponseType = ResponseType.DEFAULT)]
    public class UpdateReportAcknowledgementsRequest
    {
        private bool? _acknowledgedField;

        /// <summary>
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElement(ElementName = "Marketplace")]
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public string Marketplace { get; set; }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
        public UpdateReportAcknowledgementsRequest WithMarketplace(string marketplace)
        {
            Marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        [System.Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility.")]
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
        public UpdateReportAcknowledgementsRequest WithMerchant(string merchant)
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
        public UpdateReportAcknowledgementsRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the ReportIdList property.
        /// </summary>
        [XmlElement(ElementName = "ReportIdList")]
        public IdList ReportIdList { get; set; }

        /// <summary>
        /// Sets the ReportIdList property.
        /// </summary>
        /// <param name="reportIdList">ReportIdList property.</param>
        /// <returns>this instance.</returns>
        public UpdateReportAcknowledgementsRequest WithReportIdList(IdList reportIdList)
        {
            ReportIdList = reportIdList;
            return this;
        }

        /// <summary>
        /// Checks if ReportIdList property is set.
        /// </summary>
        /// <returns>true if ReportIdList property is set.</returns>
        public bool IsSetReportIdList()
        {
            return ReportIdList != null;
        }

        /// <summary>
        /// Gets and sets the Acknowledged property.
        /// </summary>
        [XmlElement(ElementName = "Acknowledged")]
        public bool Acknowledged
        {
            get { return _acknowledgedField.GetValueOrDefault(); }
            set { _acknowledgedField = value; }
        }

        /// <summary>
        /// Sets the Acknowledged property.
        /// </summary>
        /// <param name="acknowledged">Acknowledged property.</param>
        /// <returns>this instance.</returns>
        public UpdateReportAcknowledgementsRequest WithAcknowledged(bool acknowledged)
        {
            _acknowledgedField = acknowledged;
            return this;
        }

        /// <summary>
        /// Checks if Acknowledged property is set.
        /// </summary>
        /// <returns>true if Acknowledged property is set.</returns>
        public bool IsSetAcknowledged()
        {
            return _acknowledgedField.HasValue;
        }
    }
}

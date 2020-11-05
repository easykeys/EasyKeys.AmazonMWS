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
    public class GetReportRequestCountRequest
    {
        private DateTime? _requestedFromDateField;

        private DateTime? _requestedToDateField;

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
        public GetReportRequestCountRequest WithMarketplace(string marketplace)
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
        public GetReportRequestCountRequest WithMerchant(string merchant)
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
        public GetReportRequestCountRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the ReportTypeList property.
        /// </summary>
        [XmlElement(ElementName = "ReportTypeList")]
        public TypeList ReportTypeList { get; set; }

        /// <summary>
        /// Sets the ReportTypeList property.
        /// </summary>
        /// <param name="reportTypeList">ReportTypeList property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestCountRequest WithReportTypeList(TypeList reportTypeList)
        {
            ReportTypeList = reportTypeList;
            return this;
        }

        /// <summary>
        /// Checks if ReportTypeList property is set.
        /// </summary>
        /// <returns>true if ReportTypeList property is set.</returns>
        public bool IsSetReportTypeList()
        {
            return ReportTypeList != null;
        }

        /// <summary>
        /// Gets and sets the ReportProcessingStatusList property.
        /// </summary>
        [XmlElement(ElementName = "ReportProcessingStatusList")]
        public StatusList ReportProcessingStatusList { get; set; }

        /// <summary>
        /// Sets the ReportProcessingStatusList property.
        /// </summary>
        /// <param name="reportProcessingStatusList">ReportProcessingStatusList property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestCountRequest WithReportProcessingStatusList(StatusList reportProcessingStatusList)
        {
            ReportProcessingStatusList = reportProcessingStatusList;
            return this;
        }

        /// <summary>
        /// Checks if ReportProcessingStatusList property is set.
        /// </summary>
        /// <returns>true if ReportProcessingStatusList property is set.</returns>
        public bool IsSetReportProcessingStatusList()
        {
            return ReportProcessingStatusList != null;
        }

        /// <summary>
        /// Gets and sets the RequestedFromDate property.
        /// </summary>
        [XmlElement(ElementName = "RequestedFromDate")]
        public DateTime RequestedFromDate
        {
            get => _requestedFromDateField.GetValueOrDefault();
            set => _requestedFromDateField = value;
        }

        /// <summary>
        /// Sets the RequestedFromDate property.
        /// </summary>
        /// <param name="requestedFromDate">RequestedFromDate property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestCountRequest WithRequestedFromDate(DateTime requestedFromDate)
        {
            _requestedFromDateField = requestedFromDate;
            return this;
        }

        /// <summary>
        /// Checks if RequestedFromDate property is set.
        /// </summary>
        /// <returns>true if RequestedFromDate property is set.</returns>
        public bool IsSetRequestedFromDate()
        {
            return _requestedFromDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the RequestedToDate property.
        /// </summary>
        [XmlElement(ElementName = "RequestedToDate")]
        public DateTime RequestedToDate
        {
            get => _requestedToDateField.GetValueOrDefault();
            set => _requestedToDateField = value;
        }

        /// <summary>
        /// Sets the RequestedToDate property.
        /// </summary>
        /// <param name="requestedToDate">RequestedToDate property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequestCountRequest WithRequestedToDate(DateTime requestedToDate)
        {
            _requestedToDateField = requestedToDate;
            return this;
        }

        /// <summary>
        /// Checks if RequestedToDate property is set.
        /// </summary>
        /// <returns>true if RequestedToDate property is set.</returns>
        public bool IsSetRequestedToDate()
        {
            return _requestedToDateField.HasValue;
        }
    }
}

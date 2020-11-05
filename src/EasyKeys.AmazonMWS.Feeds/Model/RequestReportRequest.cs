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
    public class RequestReportRequest
    {
        private DateTime? _startDateField;

        private DateTime? _endDateField;

        /// <summary>
        /// Gets and sets the Marketplace property.
        /// </summary>
        [XmlElement(ElementName = "Marketplace")]
        [Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public string Marketplace { get; set; }

        /// <summary>
        /// Gets and sets the MarketplaceIdList property, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to request a report from.
        /// </summary>
        [XmlElement(ElementName = "MarketplaceIdList")]
        public IdList MarketplaceIdList { get; set; }

        /// <summary>
        /// Sets the Marketplace property.
        /// </summary>
        /// <param name="marketplace">Marketplace property.</param>
        /// <returns>this instance.</returns>
        [Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public RequestReportRequest WithMarketplace(string marketplace)
        {
            Marketplace = marketplace;
            return this;
        }

        /// <summary>
        /// Sets the MarketplaceIdList property, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to request a report from.
        /// </summary>
        /// <param name="marketplaceIdList"> MarketplaceIdList property.</param>
        /// <returns></returns>
        public RequestReportRequest WithMarketplaceIdList(IdList marketplaceIdList)
        {
            MarketplaceIdList = marketplaceIdList;
            return this;
        }

        /// <summary>
        /// Checks if Marketplace property is set.
        /// </summary>
        /// <returns>true if Marketplace property is set.</returns>
        [Obsolete("Not used anymore. MWS ignores this parameter, but it is left in here for backwards compatibility. See MarketplaceIdList to specify a Marketplace.")]
        public bool IsSetMarketplace()
        {
            return Marketplace != null;
        }

        /// <summary>
        /// Checks if MarketplaceIdList property is set, an optional parameter for backwards compatibility. Allows you to specify the marketplaces to request a report from.
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
        public string Merchant { get; set; }

        /// <summary>
        /// Sets the Merchant property.
        /// </summary>
        /// <param name="merchant">Merchant property.</param>
        /// <returns>this instance.</returns>
        public RequestReportRequest WithMerchant(string merchant)
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
        public RequestReportRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the ReportType property.
        /// </summary>
        [XmlElement(ElementName = "ReportType")]
        public string ReportType { get; set; }

        /// <summary>
        /// Sets the ReportType property.
        /// </summary>
        /// <param name="reportType">ReportType property.</param>
        /// <returns>this instance.</returns>
        public RequestReportRequest WithReportType(string reportType)
        {
            ReportType = reportType;
            return this;
        }

        /// <summary>
        /// Checks if ReportType property is set.
        /// </summary>
        /// <returns>true if ReportType property is set.</returns>
        public bool IsSetReportType()
        {
            return ReportType != null;
        }

        /// <summary>
        /// Gets and sets the StartDate property.
        /// </summary>
        [XmlElement(ElementName = "StartDate")]
        public DateTime StartDate
        {
            get => _startDateField.GetValueOrDefault();
            set => _startDateField = value;
        }

        /// <summary>
        /// Sets the StartDate property.
        /// </summary>
        /// <param name="startDate">StartDate property.</param>
        /// <returns>this instance.</returns>
        public RequestReportRequest WithStartDate(DateTime startDate)
        {
            _startDateField = startDate;
            return this;
        }

        /// <summary>
        /// Checks if StartDate property is set.
        /// </summary>
        /// <returns>true if StartDate property is set.</returns>
        public bool IsSetStartDate()
        {
            return _startDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the EndDate property.
        /// </summary>
        [XmlElement(ElementName = "EndDate")]
        public DateTime EndDate
        {
            get => _endDateField.GetValueOrDefault();
            set => _endDateField = value;
        }

        /// <summary>
        /// Sets the EndDate property.
        /// </summary>
        /// <param name="endDate">EndDate property.</param>
        /// <returns>this instance.</returns>
        public RequestReportRequest WithEndDate(DateTime endDate)
        {
            _endDateField = endDate;
            return this;
        }

        /// <summary>
        /// Checks if EndDate property is set.
        /// </summary>
        /// <returns>true if EndDate property is set.</returns>
        public bool IsSetEndDate()
        {
            return _endDateField.HasValue;
        }

        /// <summary>
        /// Gets and set the reportOption property.
        /// </summary>
        [XmlElement(ElementName = "ReportOptions")]
        public string ReportOptions { get; set; }

        /// <summary>
        /// Sets the reportOptions property.
        /// </summary>
        /// <param name="reportOptions">Report Options property.</param>
        /// <returns>this instance.</returns>
        public RequestReportRequest WithReportOptions(string reportOptions)
        {
            ReportOptions = reportOptions;
            return this;
        }

        /// <summary>
        /// Checks if the ReportOptions property is set.
        /// </summary>
        /// <returns>true if Report Options field is set.</returns>
        public bool IsSetReportOptions()
        {
            return ReportOptions != null;
        }
    }
}

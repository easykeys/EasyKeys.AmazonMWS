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
    public class GetReportCountRequest
    {
        private bool? _acknowledgedField;

        private DateTime? _availableFromDateField;

        private DateTime? _availableToDateField;

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
        public GetReportCountRequest WithMarketplace(string marketplace)
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
        public GetReportCountRequest WithMerchant(string merchant)
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
        public GetReportCountRequest WithMWSAuthToken(string mwsAuthToken)
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
        public GetReportCountRequest WithReportTypeList(TypeList reportTypeList)
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
        /// Gets and sets the Acknowledged property.
        /// </summary>
        [XmlElement(ElementName = "Acknowledged")]
        public bool Acknowledged
        {
            get => _acknowledgedField.GetValueOrDefault();
            set => _acknowledgedField = value;
        }

        /// <summary>
        /// Sets the Acknowledged property.
        /// </summary>
        /// <param name="acknowledged">Acknowledged property.</param>
        /// <returns>this instance.</returns>
        public GetReportCountRequest WithAcknowledged(bool acknowledged)
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

        /// <summary>
        /// Gets and sets the AvailableFromDate property.
        /// </summary>
        [XmlElement(ElementName = "AvailableFromDate")]
        public DateTime AvailableFromDate
        {
            get => _availableFromDateField.GetValueOrDefault();
            set => _availableFromDateField = value;
        }

        /// <summary>
        /// Sets the AvailableFromDate property.
        /// </summary>
        /// <param name="availableFromDate">AvailableFromDate property.</param>
        /// <returns>this instance.</returns>
        public GetReportCountRequest WithAvailableFromDate(DateTime availableFromDate)
        {
            _availableFromDateField = availableFromDate;
            return this;
        }

        /// <summary>
        /// Checks if AvailableFromDate property is set.
        /// </summary>
        /// <returns>true if AvailableFromDate property is set.</returns>
        public bool IsSetAvailableFromDate()
        {
            return _availableFromDateField.HasValue;
        }

        /// <summary>
        /// Gets and sets the AvailableToDate property.
        /// </summary>
        [XmlElement(ElementName = "AvailableToDate")]
        public DateTime AvailableToDate
        {
            get => _availableToDateField.GetValueOrDefault();
            set => _availableToDateField = value;
        }

        /// <summary>
        /// Sets the AvailableToDate property.
        /// </summary>
        /// <param name="availableToDate">AvailableToDate property.</param>
        /// <returns>this instance.</returns>
        public GetReportCountRequest WithAvailableToDate(DateTime availableToDate)
        {
            _availableToDateField = availableToDate;
            return this;
        }

        /// <summary>
        /// Checks if AvailableToDate property is set.
        /// </summary>
        /// <returns>true if AvailableToDate property is set.</returns>
        public bool IsSetAvailableToDate()
        {
            return _availableToDateField.HasValue;
        }
    }
}

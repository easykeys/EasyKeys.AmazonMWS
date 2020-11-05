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
    [MarketplaceWebService(RequestType = RequestType.DEFAULT, ResponseType = ResponseType.STREAMING)]
    public class GetReportRequest
    {
        private string _reportIdField;

        [MarketplaceWebServiceStream(StreamType = StreamType.RECEIVE_STREAM)]
        public Stream Report { get; set; }

        public GetReportRequest WithReport(Stream report)
        {
            Report = report;
            return this;
        }

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
        public GetReportRequest WithMarketplace(string marketplace)
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
        public GetReportRequest WithMerchant(string merchant)
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
        public GetReportRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the ReportId property.
        /// </summary>
        [XmlElement(ElementName = "ReportId")]
        public string ReportId
        {
            get { return _reportIdField; }
            set { _reportIdField = value; }
        }

        /// <summary>
        /// Sets the ReportId property.
        /// </summary>
        /// <param name="reportId">ReportId property.</param>
        /// <returns>this instance.</returns>
        public GetReportRequest WithReportId(string reportId)
        {
            _reportIdField = reportId;
            return this;
        }

        /// <summary>
        /// Checks if ReportId property is set.
        /// </summary>
        /// <returns>true if ReportId property is set.</returns>
        public bool IsSetReportId()
        {
            return _reportIdField != null;
        }

        public bool IsSetReport()
        {
            return Report != null;
        }
    }
}

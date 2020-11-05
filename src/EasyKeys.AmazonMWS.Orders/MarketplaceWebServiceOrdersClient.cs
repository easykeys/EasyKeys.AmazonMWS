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
 * Marketplace Web Service Orders
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using System;

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    /// <summary>
    /// MarketplaceWebServiceOrdersClient is an implementation of MarketplaceWebServiceOrders.
    /// </summary>
    public class MarketplaceWebServiceOrdersClient : IMarketplaceWebServiceOrders
    {
        private const string libraryVersion = "2015-09-24";

        private string _servicePath;

        private MwsConnection _connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceOrdersClient"/> class.
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key.</param>
        /// <param name="secretKey">Secret Key.</param>
        /// <param name="applicationName">Application Name.</param>
        /// <param name="applicationVersion">Application Version.</param>
        /// <param name="config">configuration.</param>
        public MarketplaceWebServiceOrdersClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            MarketplaceWebServiceOrdersConfig config)
        {
            _connection = config.CopyConnection();
            _connection.AwsAccessKeyId = accessKey;
            _connection.AwsSecretKeyId = secretKey;
            _connection.ApplicationName = applicationName;
            _connection.ApplicationVersion = applicationVersion;
            _connection.LibraryVersion = libraryVersion;
            _servicePath = config.ServicePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceOrdersClient"/> class.
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key.</param>
        /// <param name="secretKey">Secret Key.</param>
        /// <param name="config">configuration.</param>
        public MarketplaceWebServiceOrdersClient(String accessKey, String secretKey, MarketplaceWebServiceOrdersConfig config)
        {
            _connection = config.CopyConnection();
            _connection.AwsAccessKeyId = accessKey;
            _connection.AwsSecretKeyId = secretKey;
            _connection.LibraryVersion = libraryVersion;
            _servicePath = config.ServicePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceOrdersClient"/> class.
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key.</param>
        /// <param name="secretKey">Secret Key.</param>
        public MarketplaceWebServiceOrdersClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MarketplaceWebServiceOrdersConfig())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceOrdersClient"/> class.
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key.</param>
        /// <param name="secretKey">Secret Key.</param>
        /// <param name="applicationName">Application Name.</param>
        /// <param name="applicationVersion">Application Version.</param>
        public MarketplaceWebServiceOrdersClient(
            String accessKey,
            String secretKey,
            String applicationName,
            String applicationVersion)
            : this(
                  accessKey,
                  secretKey,
                  applicationName,
                  applicationVersion,
                  new MarketplaceWebServiceOrdersConfig())
        {
        }

        public GetOrderResponse GetOrder(GetOrderRequest request)
        {
            return _connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<GetOrderResponse>("GetOrder", typeof(GetOrderResponse), _servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return _connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), _servicePath),
                request);
        }

        public ListOrderItemsResponse ListOrderItems(ListOrderItemsRequest request)
        {
            return _connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrderItemsResponse>("ListOrderItems", typeof(ListOrderItemsResponse), _servicePath),
                request);
        }

        public ListOrderItemsByNextTokenResponse ListOrderItemsByNextToken(ListOrderItemsByNextTokenRequest request)
        {
            return _connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrderItemsByNextTokenResponse>("ListOrderItemsByNextToken", typeof(ListOrderItemsByNextTokenResponse), _servicePath),
                request);
        }

        public ListOrdersResponse ListOrders(ListOrdersRequest request)
        {
            return _connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrdersResponse>("ListOrders", typeof(ListOrdersResponse), _servicePath),
                request);
        }

        public ListOrdersByNextTokenResponse ListOrdersByNextToken(ListOrdersByNextTokenRequest request)
        {
            return _connection.Call(
                new MarketplaceWebServiceOrdersClient.Request<ListOrdersByNextTokenResponse>("ListOrdersByNextToken", typeof(ListOrdersByNextTokenResponse), _servicePath),
                request);
        }

        private class Request<R> : IMwsRequestType<R> where R : IMwsObject
        {
            public Request(string operationName, Type responseClass, string servicePath)
            {
                OperationName = operationName;
                ResponseClass = responseClass;
                ServicePath = servicePath;
            }

            public string ServicePath { get; }

            public string OperationName { get; }

            public Type ResponseClass { get; }

            public MwsException WrapException(Exception cause)
            {
                return new MarketplaceWebServiceOrdersException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd)
            {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }
        }
    }
}

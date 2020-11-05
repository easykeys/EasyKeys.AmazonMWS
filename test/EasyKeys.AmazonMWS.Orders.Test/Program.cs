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
using System.Collections.Generic;

using EasyKeys.AmazonMWS.Orders.Model;

namespace EasyKeys.AmazonMWS.Orders.Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Set the below configuration variables before attempting to run

            // Developer AWS access key
            var accessKey = "replaceWithAccessKey";

            // Developer AWS secret key
            var secretKey = "replaceWithSecretKey";

            // The client application name
            var appName = "CSharpSampleCode";

            // The client application version
            var appVersion = "1.0";

            // The endpoint for region service and version (see developer guide)
            // ex: https://mws.amazonservices.com
            var serviceURL = "replaceWithServiceURL";

            // Create a configuration object
            var config = new MarketplaceWebServiceOrdersConfig();
            config.ServiceURL = serviceURL;

            // Set other client connection configurations here if needed
            // Create the client itself
            IMarketplaceWebServiceOrders client = new MarketplaceWebServiceOrdersClient(accessKey, secretKey, appName, appVersion, config);

            var sample = new Program(client);

            // Uncomment the operation you'd like to test here
            // TODO: Modify the request created in the Invoke method to be valid

            try
            {
                IMWSResponse response = null;

                // response = sample.InvokeGetOrder();
                // response = sample.InvokeGetServiceStatus();
                // response = sample.InvokeListOrderItems();
                // response = sample.InvokeListOrderItemsByNextToken();
                // response = sample.InvokeListOrders();
                // response = sample.InvokeListOrdersByNextToken();
                Console.WriteLine("Response:");
                var rhmd = response.ResponseHeaderMetadata;

                // We recommend logging the request id and timestamp of every call.
                Console.WriteLine("RequestId: " + rhmd.RequestId);
                Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                var responseXml = response.ToXML();
                Console.WriteLine(responseXml);
            }
            catch (MarketplaceWebServiceOrdersException ex)
            {
                // Exception properties are important for diagnostics.
                var rhmd = ex.ResponseHeaderMetadata;
                Console.WriteLine("Service Exception:");
                if (rhmd != null)
                {
                    Console.WriteLine("RequestId: " + rhmd.RequestId);
                    Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                }

                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("StatusCode: " + ex.StatusCode);
                Console.WriteLine("ErrorCode: " + ex.ErrorCode);
                Console.WriteLine("ErrorType: " + ex.ErrorType);
                throw ex;
            }
        }

        private readonly IMarketplaceWebServiceOrders _client;

        public Program(IMarketplaceWebServiceOrders client)
        {
            _client = client;
        }

        public GetOrderResponse InvokeGetOrder()
        {
            // Create a request.
            var request = new GetOrderRequest();
            var sellerId = "example";
            request.SellerId = sellerId;
            var mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            var amazonOrderId = new List<string>();
            request.AmazonOrderId = amazonOrderId;
            return _client.GetOrder(request);
        }

        public GetServiceStatusResponse InvokeGetServiceStatus()
        {
            // Create a request.
            var request = new GetServiceStatusRequest();
            var sellerId = "example";
            request.SellerId = sellerId;
            var mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            return _client.GetServiceStatus(request);
        }

        public ListOrderItemsResponse InvokeListOrderItems()
        {
            // Create a request.
            var request = new ListOrderItemsRequest();
            var sellerId = "example";
            request.SellerId = sellerId;
            var mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            var amazonOrderId = "example";
            request.AmazonOrderId = amazonOrderId;
            return _client.ListOrderItems(request);
        }

        public ListOrderItemsByNextTokenResponse InvokeListOrderItemsByNextToken()
        {
            // Create a request.
            var request = new ListOrderItemsByNextTokenRequest();
            var sellerId = "example";
            request.SellerId = sellerId;
            var mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            var nextToken = "example";
            request.NextToken = nextToken;
            return _client.ListOrderItemsByNextToken(request);
        }

        public ListOrdersResponse InvokeListOrders()
        {
            // Create a request.
            var request = new ListOrdersRequest();
            var sellerId = "example";
            request.SellerId = sellerId;
            var mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            DateTime createdAfter = default;
            request.CreatedAfter = createdAfter;
            DateTime createdBefore = default;
            request.CreatedBefore = createdBefore;
            DateTime lastUpdatedAfter = default;
            request.LastUpdatedAfter = lastUpdatedAfter;
            DateTime lastUpdatedBefore = default;
            request.LastUpdatedBefore = lastUpdatedBefore;
            var orderStatus = new List<string>();
            request.OrderStatus = orderStatus;
            var marketplaceId = new List<string>();
            request.MarketplaceId = marketplaceId;
            var fulfillmentChannel = new List<string>();
            request.FulfillmentChannel = fulfillmentChannel;
            var paymentMethod = new List<string>();
            request.PaymentMethod = paymentMethod;
            var buyerEmail = "example";
            request.BuyerEmail = buyerEmail;
            var sellerOrderId = "example";
            request.SellerOrderId = sellerOrderId;
            decimal maxResultsPerPage = 1;
            request.MaxResultsPerPage = maxResultsPerPage;
            var tfmShipmentStatus = new List<string>();
            request.TFMShipmentStatus = tfmShipmentStatus;
            return _client.ListOrders(request);
        }

        public ListOrdersByNextTokenResponse InvokeListOrdersByNextToken()
        {
            // Create a request.
            var request = new ListOrdersByNextTokenRequest();
            var sellerId = "example";
            request.SellerId = sellerId;
            var mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            var nextToken = "example";
            request.NextToken = nextToken;
            return _client.ListOrdersByNextToken(request);
        }
    }
}

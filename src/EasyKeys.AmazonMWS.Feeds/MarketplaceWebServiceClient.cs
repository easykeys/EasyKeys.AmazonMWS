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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

using EasyKeys.AmazonMWS.Feeds.Attributes;

using EasyKeys.AmazonMWS.Feeds.Model;

namespace EasyKeys.AmazonMWS.Feeds
{
    /**

     *
     * MarketplaceWebServiceClient is an implementation of MarketplaceWebService
     *
     */
    public class MarketplaceWebServiceClient : IMarketplaceWebService
    {
        private string _awsAccessKeyId = null;
        private string _awsSecretAccessKey = null;
        private MarketplaceWebServiceConfig _config = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceClient"/> class.
        /// Constructs MarketplaceWebServiceClient with AWS Access Key ID and AWS Secret Key.
        /// Since the User-Agent is required for all MWS calls, this value must be set
        /// in the config.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID.</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key.</param>
        /// <param name="config">Custom Configuration (User-Agent is set).</param>
        public MarketplaceWebServiceClient(
           string awsAccessKeyId,
           string awsSecretAccessKey,
           MarketplaceWebServiceConfig config)
        {
            _awsAccessKeyId = awsAccessKeyId;
            _awsSecretAccessKey = awsSecretAccessKey;

            if (!config.IsSetUserAgent())
            {
                throw new MarketplaceWebServiceException("Missing required value: User-Agent.");
            }

            _config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceClient"/> class.
        /// Constructs MarketplaceWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// an application name, and application version.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID.</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key.</param>
        /// <param name="applicationName">Application Name.</param>
        /// <param name="applicationVersion">Application Version.</param>
        public MarketplaceWebServiceClient(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string applicationName,
            string applicationVersion)
            : this(
                awsAccessKeyId,
                awsSecretAccessKey,
                applicationName,
                applicationVersion,
                new MarketplaceWebServiceConfig())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceWebServiceClient"/> class.
        /// Constructs MarketplaceWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// an application name, and application version.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID.</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key.</param>
        /// <param name="applicationName">Application Name.</param>
        /// <param name="applicationVersion">Application Version.</param>
        /// <param name="config"></param>
        /// ///
        public MarketplaceWebServiceClient(
            string awsAccessKeyId,
            string awsSecretAccessKey,
            string applicationName,
            string applicationVersion,
            MarketplaceWebServiceConfig config)
        {
            _awsAccessKeyId = awsAccessKeyId;
            _awsSecretAccessKey = awsSecretAccessKey;
            _config = config;

            BuildUserAgentHeader(applicationName, applicationVersion, config);
        }

        private const string mwsClientVersion = "2016-09-21";

        private void BuildUserAgentHeader(
            string applicationName,
            string applicationVersion,
            MarketplaceWebServiceConfig config)
        {
            config.SetUserAgentHeader(
                applicationName,
                applicationVersion,
                "C#",
                "CLI",
                ".NET Standard 1.5",
                "Platform",
                ".NET Standard 1.5",
                "MWSClientVersion",
                mwsClientVersion);
        }

        // Public API ------------------------------------------------------------//

        /// <summary>
        /// Get Report.
        /// </summary>
        /// <param name="request">Get Report  request.</param>
        /// <returns>Get Report  Response from the service.</returns>
        /// <remarks>
        /// The GetReport operation returns the contents of a report. Reports can potentially be
        /// very large (>100MB) which is why we only return one report at a time, and in a
        /// streaming fashion.
        ///
        /// </remarks>
#pragma warning disable SA1202 // Elements should be ordered by access
        public async Task<GetReportResponse> GetReport(GetReportRequest request)
#pragma warning restore SA1202 // Elements should be ordered by access
        {
            return await Invoke<GetReportResponse, GetReportRequest>(ConvertGetReport(request), request);
        }

        /// <summary>
        /// Get Report Schedule Count.
        /// </summary>
        /// <param name="request">Get Report Schedule Count  request.</param>
        /// <returns>Get Report Schedule Count  Response from the service.</returns>
        /// <remarks>
        /// returns the number of report schedules.
        ///
        /// </remarks>
        public async Task<GetReportScheduleCountResponse> GetReportScheduleCount(GetReportScheduleCountRequest request)
        {
            return await Invoke<GetReportScheduleCountResponse>(ConvertGetReportScheduleCount(request));
        }

        /// <summary>
        /// Get Report Request List By Next Token.
        /// </summary>
        /// <param name="request">Get Report Request List By Next Token  request.</param>
        /// <returns>Get Report Request List By Next Token  Response from the service.</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve.
        ///
        /// </remarks>
        public async Task<GetReportRequestListByNextTokenResponse> GetReportRequestListByNextToken(GetReportRequestListByNextTokenRequest request)
        {
            return await Invoke<GetReportRequestListByNextTokenResponse>(ConvertGetReportRequestListByNextToken(request));
        }

        /// <summary>
        /// Update Report Acknowledgements.
        /// </summary>
        /// <param name="request">Update Report Acknowledgements  request.</param>
        /// <returns>Update Report Acknowledgements  Response from the service.</returns>
        /// <remarks>
        /// The UpdateReportAcknowledgements operation updates the acknowledged status of one or more reports.
        ///
        /// </remarks>
        public async Task<UpdateReportAcknowledgementsResponse> UpdateReportAcknowledgements(UpdateReportAcknowledgementsRequest request)
        {
            return await Invoke<UpdateReportAcknowledgementsResponse>(ConvertUpdateReportAcknowledgements(request));
        }

        /// <summary>
        /// Submit Feed.
        /// </summary>
        /// <param name="request">Submit Feed  request.</param>
        /// <returns>Submit Feed  Response from the service.</returns>
        /// <remarks>
        /// Uploads a file for processing together with the necessary
        /// metadata to process the file, such as which type of feed it is.
        /// PurgeAndReplace if true means that your existing e.g. inventory is
        /// wiped out and replace with the contents of this feed - use with
        /// caution (the default is false).
        ///
        /// </remarks>
        public async Task<SubmitFeedResponse> SubmitFeed(SubmitFeedRequest request)
        {
            return await Invoke<SubmitFeedResponse, SubmitFeedRequest>(ConvertSubmitFeed(request), request);
        }

        /// <summary>
        /// Get Report Count.
        /// </summary>
        /// <param name="request">Get Report Count  request.</param>
        /// <returns>Get Report Count  Response from the service.</returns>
        /// <remarks>
        /// returns a count of reports matching your criteria;
        /// by default, the number of reports generated in the last 90 days,
        /// regardless of acknowledgement status.
        ///
        /// </remarks>
        public async Task<GetReportCountResponse> GetReportCount(GetReportCountRequest request)
        {
            return await Invoke<GetReportCountResponse>(ConvertGetReportCount(request));
        }

        /// <summary>
        /// Get Feed Submission List By Next Token.
        /// </summary>
        /// <param name="request">Get Feed Submission List By Next Token  request.</param>
        /// <returns>Get Feed Submission List By Next Token  Response from the service.</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve.
        ///
        /// </remarks>
        public async Task<GetFeedSubmissionListByNextTokenResponse> GetFeedSubmissionListByNextToken(GetFeedSubmissionListByNextTokenRequest request)
        {
            return await Invoke<GetFeedSubmissionListByNextTokenResponse>(ConvertGetFeedSubmissionListByNextToken(request));
        }

        /// <summary>
        /// Cancel Feed Submissions.
        /// </summary>
        /// <param name="request">Cancel Feed Submissions  request.</param>
        /// <returns>Cancel Feed Submissions  Response from the service.</returns>
        /// <remarks>
        /// cancels feed submissions - by default all of the submissions of the
        /// last 30 days that have not started processing.
        ///
        /// </remarks>
        public async Task<CancelFeedSubmissionsResponse> CancelFeedSubmissions(CancelFeedSubmissionsRequest request)
        {
            return await Invoke<CancelFeedSubmissionsResponse>(ConvertCancelFeedSubmissions(request));
        }

        /// <summary>
        /// Request Report.
        /// </summary>
        /// <param name="request">Request Report  request.</param>
        /// <returns>Request Report  Response from the service.</returns>
        /// <remarks>
        /// requests the generation of a report.
        ///
        /// </remarks>
        public async Task<RequestReportResponse> RequestReport(RequestReportRequest request)
        {
            return await Invoke<RequestReportResponse>(ConvertRequestReport(request));
        }

        /// <summary>
        /// Get Feed Submission Count.
        /// </summary>
        /// <param name="request">Get Feed Submission Count  request.</param>
        /// <returns>Get Feed Submission Count  Response from the service.</returns>
        /// <remarks>
        /// returns the number of feeds matching all of the specified criteria.
        ///
        /// </remarks>
        public async Task<GetFeedSubmissionCountResponse> GetFeedSubmissionCount(GetFeedSubmissionCountRequest request)
        {
            return await Invoke<GetFeedSubmissionCountResponse>(ConvertGetFeedSubmissionCount(request));
        }

        /// <summary>
        /// Cancel Report Requests.
        /// </summary>
        /// <param name="request">Cancel Report Requests  request.</param>
        /// <returns>Cancel Report Requests  Response from the service.</returns>
        /// <remarks>
        /// cancels report requests that have not yet started processing,
        /// by default all those within the last 90 days.
        ///
        /// </remarks>
        public async Task<CancelReportRequestsResponse> CancelReportRequests(CancelReportRequestsRequest request)
        {
            return await Invoke<CancelReportRequestsResponse>(ConvertCancelReportRequests(request));
        }

        /// <summary>
        /// Get Report List.
        /// </summary>
        /// <param name="request">Get Report List  request.</param>
        /// <returns>Get Report List  Response from the service.</returns>
        /// <remarks>
        /// returns a list of reports; by default the most recent ten reports,
        /// regardless of their acknowledgement status.
        ///
        /// </remarks>
        public async Task<GetReportListResponse> GetReportList(GetReportListRequest request)
        {
            return await Invoke<GetReportListResponse>(ConvertGetReportList(request));
        }

        /// <summary>
        /// Get Feed Submission Result.
        /// </summary>
        /// <param name="request">Get Feed Submission Result  request.</param>
        /// <returns>Get Feed Submission Result  Response from the service.</returns>
        /// <remarks>
        /// retrieves the feed processing report.
        ///
        /// </remarks>
        public async Task<GetFeedSubmissionResultResponse> GetFeedSubmissionResult(GetFeedSubmissionResultRequest request)
        {
            return await Invoke<GetFeedSubmissionResultResponse, GetFeedSubmissionResultRequest>(ConvertGetFeedSubmissionResult(request), request);
        }

        /// <summary>
        /// Get Feed Submission List.
        /// </summary>
        /// <param name="request">Get Feed Submission List  request.</param>
        /// <returns>Get Feed Submission List  Response from the service.</returns>
        /// <remarks>
        /// returns a list of feed submission identifiers and their associated metadata.
        ///
        /// </remarks>
        public async Task<GetFeedSubmissionListResponse> GetFeedSubmissionList(GetFeedSubmissionListRequest request)
        {
            return await Invoke<GetFeedSubmissionListResponse>(ConvertGetFeedSubmissionList(request));
        }

        /// <summary>
        /// Get Report Request List.
        /// </summary>
        /// <param name="request">Get Report Request List  request.</param>
        /// <returns>Get Report Request List  Response from the service.</returns>
        /// <remarks>
        /// returns a list of report requests ids and their associated metadata.
        ///
        /// </remarks>
        public async Task<GetReportRequestListResponse> GetReportRequestList(GetReportRequestListRequest request)
        {
            return await Invoke<GetReportRequestListResponse>(ConvertGetReportRequestList(request));
        }

        /// <summary>
        /// Get Report Schedule List By Next Token.
        /// </summary>
        /// <param name="request">Get Report Schedule List By Next Token  request.</param>
        /// <returns>Get Report Schedule List By Next Token  Response from the service.</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve.
        ///
        /// </remarks>
        public async Task<GetReportScheduleListByNextTokenResponse> GetReportScheduleListByNextToken(GetReportScheduleListByNextTokenRequest request)
        {
            return await Invoke<GetReportScheduleListByNextTokenResponse>(ConvertGetReportScheduleListByNextToken(request));
        }

        /// <summary>
        /// Get Report List By Next Token.
        /// </summary>
        /// <param name="request">Get Report List By Next Token  request.</param>
        /// <returns>Get Report List By Next Token  Response from the service.</returns>
        /// <remarks>
        /// retrieve the next batch of list items and if there are more items to retrieve.
        ///
        /// </remarks>
        public async Task<GetReportListByNextTokenResponse> GetReportListByNextToken(GetReportListByNextTokenRequest request)
        {
            return await Invoke<GetReportListByNextTokenResponse>(ConvertGetReportListByNextToken(request));
        }

        /// <summary>
        /// Manage Report Schedule.
        /// </summary>
        /// <param name="request">Manage Report Schedule  request.</param>
        /// <returns>Manage Report Schedule  Response from the service.</returns>
        /// <remarks>
        /// Creates, updates, or deletes a report schedule
        /// for a given report type, such as order reports in particular.
        ///
        /// </remarks>
        public async Task<ManageReportScheduleResponse> ManageReportSchedule(ManageReportScheduleRequest request)
        {
            return await Invoke<ManageReportScheduleResponse>(ConvertManageReportSchedule(request));
        }

        /// <summary>
        /// Get Report Request Count.
        /// </summary>
        /// <param name="request">Get Report Request Count  request.</param>
        /// <returns>Get Report Request Count  Response from the service.</returns>
        /// <remarks>
        /// returns a count of report requests; by default all the report
        /// requests in the last 90 days.
        ///
        /// </remarks>
        public async Task<GetReportRequestCountResponse> GetReportRequestCount(GetReportRequestCountRequest request)
        {
            return await Invoke<GetReportRequestCountResponse>(ConvertGetReportRequestCount(request));
        }

        /// <summary>
        /// Get Report Schedule List.
        /// </summary>
        /// <param name="request">Get Report Schedule List  request.</param>
        /// <returns>Get Report Schedule List  Response from the service.</returns>
        /// <remarks>
        /// returns the list of report schedules.
        ///
        /// </remarks>
        public async Task<GetReportScheduleListResponse> GetReportScheduleList(GetReportScheduleListRequest request)
        {
            return await Invoke<GetReportScheduleListResponse>(ConvertGetReportScheduleList(request));
        }

        // Private API ------------------------------------------------------------//

        private HttpWebRequest ConfigureWebRequest(string queryParameters, ContentType contentType)
        {
            string serviceUrl;
            if (_config.ServiceURL.EndsWith("/", StringComparison.Ordinal))
            {
                serviceUrl = _config.ServiceURL.Substring(0, _config.ServiceURL.Length - 1);
            }
            else
            {
                serviceUrl = _config.ServiceURL;
            }

            var request = WebRequest.Create(
                serviceUrl + "/?" + queryParameters) as HttpWebRequest;

            if (_config.IsSetProxyHost())
            {
                request.Proxy = new WebProxy(_config.ProxyHost, _config.ProxyPort);
            }

            request.UserAgent = _config.UserAgent;

            request.Method = "POST";
            request.Timeout = _config.RequestTimeout;

            request.ContentType = contentType.ToString();

            request.SendChunked = true;

            return request;
        }

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from MarketplaceWebServiceConfig instance
         */
        private HttpWebRequest ConfigureWebRequest(int contentLength)
        {
            var request = WebRequest.Create(_config.ServiceURL) as HttpWebRequest;

            if (_config.IsSetProxyHost())
            {
                request.Proxy = new WebProxy(_config.ProxyHost, _config.ProxyPort);
            }

            request.UserAgent = _config.UserAgent;
            request.Method = "POST";
            request.Timeout = 50000;
            request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            request.ContentLength = contentLength;

            return request;
        }

        private async Task<T> Invoke<T>(IDictionary<string, string> parameters)
        {
            return await Invoke<T, object>(parameters, null);
        }

        /**
         * Invoke request and return response
         */
        private async Task<T> Invoke<T, K>(IDictionary<string, string> parameters, K clazz)
        {
            var actionName = parameters["Action"];
            var response = default(T);
            string responseBody = null;
            var statusCode = default(HttpStatusCode);
            ResponseHeaderMetadata rhm = null;

            // Verify service URL is set.
            if (string.IsNullOrEmpty(_config.ServiceURL))
            {
                throw new MarketplaceWebServiceException(new ArgumentException(
                    "Missing serviceUrl configuration value. You may obtain a list of valid MWS URLs by consulting the MWS Developer's Guide, or reviewing the sample code published along side this library."));
            }

            /* Add required request parameters */
            AddRequiredParameters(parameters);

            var queryString = GetParametersAsString(parameters);
            var requestData = new UTF8Encoding().GetBytes(queryString);

            HttpWebRequest request;

            var isStreamingResponse = ExpectStreamingResponse(typeof(K));

            var shouldRetry = true;
            var retries = 0;
            do
            {
                /* Submit the request and read response body */
                try
                {
                    var requestType = GetMarketplaceWebServiceRequestType(typeof(K));
                    switch (requestType)
                    {
                        case RequestType.STREAMING:
                            {
                                if (clazz is SubmitFeedRequest req)
                                {
                                    // SubmitFeedRequests can configure the content type.
                                    request = ConfigureWebRequest(queryString, req.ContentType);
                                }
                                else
                                {
                                    // Send request using a default content-type.
                                    request = ConfigureWebRequest(queryString, new ContentType(MediaType.OctetStream));
                                }
                            }

                            break;
                        default:
                            request = ConfigureWebRequest(requestData.Length);
                            break;
                    }

                    var headers = request.Headers;

                    using (var requestStream = await request.GetRequestStreamAsync())
                    {
                        switch (requestType)
                        {
                            case RequestType.STREAMING:
                                var inputStream = GetTransferStream(clazz, StreamType.REQUEST_STREAM);
                                inputStream.Position = 0;
                                CopyStream(inputStream, requestStream);
                                break;
                            default:
                                requestStream.Write(requestData, 0, requestData.Length);
                                break;
                        }
                    }

                    using (var httpResponse = await request.GetResponseAsync() as HttpWebResponse)
                    {
                        statusCode = httpResponse.StatusCode;
                        rhm = new ResponseHeaderMetadata(
                            httpResponse.Headers["x-mws-request-id"],
                            httpResponse.Headers["x-mws-response-context"],
                            httpResponse.Headers["x-mws-timestamp"],
                            httpResponse.Headers["x-mws-quota-max"],
                            httpResponse.Headers["x-mws-quota-remaining"],
                            httpResponse.Headers["x-mws-quota-resetsOn"]);

                        if (isStreamingResponse && statusCode == HttpStatusCode.OK)
                        {
                            response = HandleStreamingResponse<T>(httpResponse, clazz);
                        }
                        else
                        {
                            var reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
                            responseBody = reader.ReadToEnd();
                            var serlizer = new XmlSerializer(typeof(T));
                            response = (T)serlizer.Deserialize(new StringReader(responseBody));
                        }

                        var pi = typeof(T).GetProperty("ResponseHeaderMetadata");
                        pi.SetValue(response, rhm, null);

                        shouldRetry = false;
                    }

                    /* Attempt to deserialize response into <Action> Response type */
                }

                /* Web exception is thrown on unsucessful responses */
                catch (WebException we)
                {
                    shouldRetry = false;
                    using (var httpErrorResponse = (HttpWebResponse)we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            throw new MarketplaceWebServiceException(we);
                        }

                        statusCode = httpErrorResponse.StatusCode;
                        var reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8);
                        responseBody = reader.ReadToEnd();
                    }

                    /* Attempt to deserialize response into ErrorResponse type */
                    try
                    {
                        var serlizer = new XmlSerializer(typeof(ErrorResponse));
                        var errorResponse = (ErrorResponse)serlizer.Deserialize(new StringReader(responseBody));
                        var error = errorResponse.Error[0];

                        var retriableError = statusCode == HttpStatusCode.InternalServerError
                            || statusCode == HttpStatusCode.ServiceUnavailable;
                        retriableError = retriableError && error.Code != "RequestThrottled";

                        if (retriableError && retries < _config.MaxErrorRetry)
                        {
                            PauseOnRetry(++retries);
                            shouldRetry = true;
                            continue;
                        }
                        else
                        {
                            shouldRetry = false;
                        }

                        /* Throw formatted exception with information available from the error response */
                        throw new MarketplaceWebServiceException(
                            error.Message,
                            statusCode,
                            error.Code,
                            error.Type,
                            errorResponse.RequestId,
                            errorResponse.ToXML(),
                            rhm);
                    }

                    /* Rethrow on deserializer error */
                    catch (Exception e)
                    {
                        if (e is MarketplaceWebServiceException)
                        {
                            throw e;
                        }
                        else
                        {
                            var se = ReportAnyErrors(responseBody, statusCode, e, rhm);
                            throw se;
                        }
                    }
                }

                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception e)
                {
                    throw new MarketplaceWebServiceException(e);
                }
            }
            while (shouldRetry);

            return response;
        }

        /**
         * Examines the request type and determines if the MarketplaceWebService attribute
         * has the ResponseType set to ResponseType.STREAMING. The response from the service
         * will be written to the stream marked with the MarketplaceWebServiceStream attribute.
         */
        private bool ExpectStreamingResponse(Type type)
        {
            if (type == null)
            {
                return false;
            }

            var attribute = (MarketplaceWebServiceAttribute)type.GetTypeInfo().GetCustomAttribute(typeof(MarketplaceWebServiceAttribute));

            if (attribute == null)
            {
                return false;
            }
            else
            {
                return attribute.ResponseType == ResponseType.STREAMING;
            }
        }

        /**
         * Returns the RequestType of the request, as set in the MarketplaceWebService attribute.
         * If the attribute is missing from the request, it is assumed that the request type
         * is RequestType.DEFAULT.
         */
        private RequestType GetMarketplaceWebServiceRequestType(Type type)
        {
            if (type == null || type == typeof(object))
            {
                return RequestType.DEFAULT;
            }

            var attribute = (MarketplaceWebServiceAttribute)type.GetTypeInfo().GetCustomAttribute(typeof(MarketplaceWebServiceAttribute));

            return attribute.RequestType;
        }

        /**
         * Based on StreamType, get a reference to a Stream set in the request instance.
         */
        private Stream GetTransferStream(object request, StreamType streamType)
        {
            if (request == null || !request.GetType().GetTypeInfo().IsClass)
            {
                throw new ArgumentException("request must be a class reference");
            }

            Stream s = null;

            foreach (var mi in request.GetType().GetMethods())
            {
                var attribute = (MarketplaceWebServiceStreamAttribute)mi.GetCustomAttribute(typeof(MarketplaceWebServiceStreamAttribute));

                if (attribute != null && attribute.StreamType == streamType)
                {
                    s = (Stream)mi.Invoke(request, null);
                }
            }

            foreach (var pi in request.GetType().GetProperties())
            {
                var attribute = (MarketplaceWebServiceStreamAttribute)pi.GetCustomAttribute(typeof(MarketplaceWebServiceStreamAttribute));

                if (attribute != null && attribute.StreamType == streamType)
                {
                    s = (Stream)pi.GetValue(request, null);
                }
            }

            return s;
        }

        /**
         * For streaming responses, the HTTP response body will not be marshaled into a
         * Response object, but rather streamed into a writable stream defined in the inital
         * request. For these response types, response metadata, RequestId and the Content-MD5 values,
         * are sent in the HTTP header. This method constructs a psuedo response document and
         * marshals it into a Response object.
         */
        private T DeserializeStreamingResponse<T>(IDictionary<string, string> responseElements)
        {
            var responseElementBase = typeof(T).Name;

            if (responseElementBase.EndsWith("Response"))
            {
                responseElementBase = responseElementBase.Remove(responseElementBase.Length - "Response".Length);
            }

            var sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");
            sb.Append("  <{0}Response xmlns=\"http://mws.amazonaws.com/doc/2009-01-01/\">\n");
            sb.Append("    <{0}Result>\n");
            sb.Append("      <ContentMD5>{1}</ContentMD5>\n");
            sb.Append("    </{0}Result>\n");
            sb.Append("  <ResponseMetadata>\n");
            sb.Append("    <RequestId>{2}</RequestId>\n");
            sb.Append("  </ResponseMetadata>\n");
            sb.Append("</{0}Response>\n");

            var serlizer = new XmlSerializer(typeof(T));

            var response = default(T);
            response = (T)serlizer.Deserialize(new StringReader(
              string.Format(
                sb.ToString(), responseElementBase, responseElements["ContentMD5"], responseElements["RequestId"])));

            return response;
        }

        /**
         * For requests that have defined a ResponseType of ResponseType.STREAMING, this
         * method will write the HTTP response body into the stream marked with the
         * MarketplaceWebServiceStream attribute, setting the StreamType to StreamType.RECEIVE_STREAM.
         * In addition to writing the response, the Content-MD5 returned by the service
         * will be compared for equality to a locally calculated value.
         *
         * Content-MD5 comparison failure will result in a MarketplaceWebServiceException to be
         * thrown.
         */
        private T HandleStreamingResponse<T>(HttpWebResponse webResponse, object clazz)
        {
            var receiverStream = GetTransferStream(clazz, StreamType.RECEIVE_STREAM);

            CopyStream(webResponse.GetResponseStream(), receiverStream);
            receiverStream.Position = 0;

            var headers = webResponse.Headers;
            var receivedContentMD5 = headers["Content-MD5"];
            var expectedContentMD5 = CalculateContentMD5(receiverStream);

            receiverStream.Position = 0;

            if (receivedContentMD5 != expectedContentMD5)
            {
                throw new MarketplaceWebServiceException(
                    "Received Content MD5 value " + receivedContentMD5 +
                    " doesn't match computed value " + expectedContentMD5 + ".");
            }

            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "RequestId", headers["x-amz-request-id"] },
                { "ContentMD5", headers["Content-MD5"] }
            };

            return DeserializeStreamingResponse<T>(parameters);
        }

        /**
         * Calculates the MD5 hash value.
         */
#pragma warning disable SA1202 // Elements should be ordered by access
        public static string CalculateContentMD5(Stream content)
#pragma warning restore SA1202 // Elements should be ordered by access
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(content);
            return Convert.ToBase64String(hash);
        }

        /**
         * Copy the contents of the from stream, into the to stream.
         * It is assumed that from has an overridden Read method, and that
         * to has an overridden Write method.
         */
        private void CopyStream(Stream from, Stream to)
        {
            if (!from.CanRead)
            {
                throw new ArgumentException("from Stream must implement the Read method.");
            }

            if (!to.CanWrite)
            {
                throw new ArgumentException("to Stream must implement the Write method.");
            }

            const int SIZE = 1024 * 1024;
            var buffer = new byte[SIZE];

            var read = 0;
            while ((read = from.Read(buffer, 0, buffer.Length)) > 0)
            {
                to.Write(buffer, 0, read);
            }
        }

        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private MarketplaceWebServiceException ReportAnyErrors(string responseBody, HttpStatusCode status, Exception e, ResponseHeaderMetadata rhm)
        {
            MarketplaceWebServiceException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                var errorMatcherOne = Regex.Match(responseBody, "<RequestId>(.*)</RequestId>.*<Error>" + "<Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?", RegexOptions.Multiline);
                var errorMatcherTwo = Regex.Match(responseBody, "<Error><Code>(.*)</Code><Message>(.*)" + "</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>", RegexOptions.Multiline);

                if (errorMatcherOne.Success)
                {
                    var requestId = errorMatcherOne.Groups[1].Value;
                    var code = errorMatcherOne.Groups[2].Value;
                    var message = errorMatcherOne.Groups[3].Value;

                    ex = new MarketplaceWebServiceException(message, status, code, "Unknown", requestId, responseBody, rhm);
                }
                else if (errorMatcherTwo.Success)
                {
                    var code = errorMatcherTwo.Groups[1].Value;
                    var message = errorMatcherTwo.Groups[2].Value;
                    var requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new MarketplaceWebServiceException(message, status, code, "Unknown", requestId, responseBody, rhm);
                }
                else
                {
                    ex = new MarketplaceWebServiceException("Internal Error", status, rhm);
                }
            }
            else
            {
                ex = new MarketplaceWebServiceException("Internal Error", status, rhm);
            }

            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private void PauseOnRetry(int retries)
        {
            var delay = (int)Math.Pow(4, retries) * 100;
            System.Threading.Thread.Sleep(delay);
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters)
        {
            parameters.Add("AWSAccessKeyId", _awsAccessKeyId);
            parameters.Add("Timestamp", GetFormattedTimestamp(DateTime.Now));
            parameters.Add("Version", _config.ServiceVersion);
            parameters.Add("SignatureVersion", _config.SignatureVersion);
            parameters.Add("Signature", SignParameters(parameters, _awsSecretAccessKey));
        }

        /**
         * Convert Dictionary of paremeters to Url encoded query string
         */
        private string GetParametersAsString(IDictionary<string, string> parameters)
        {
            var data = new StringBuilder();
            foreach (var key in (IEnumerable<string>)parameters.Keys)
            {
                var value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(UrlEncode(value, false));
                    data.Append('&');
                }
            }

            var result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /**
         * Computes RFC 2104-compliant HMAC signature for request parameters
         * Implements AWS Signature, as per following spec:
         *
         * If Signature Version is 0, it signs concatenated Action and Timestamp
         *
         * If Signature Version is 1, it performs the following:
         *
         * Sorts all  parameters (including SignatureVersion and excluding Signature,
         * the value of which is being created), ignoring case.
         *
         * Iterate over the sorted list and append the parameter name (in original case)
         * and then its value. It will not URL-encode the parameter values before
         * constructing this string. There are no separators.
         *
         * If Signature Version is 2, string to sign is based on following:
         *
         *    1. The HTTP Request Method followed by an ASCII newline (%0A)
         *    2. The HTTP Host header in the form of lowercase host, followed by an ASCII newline.
         *    3. The URL encoded HTTP absolute path component of the URI
         *       (up to but not including the query string parameters);
         *       if this is empty use a forward '/'. This parameter is followed by an ASCII newline.
         *    4. The concatenation of all query string components (names and values)
         *       as UTF-8 characters which are URL encoded as per RFC 3986
         *       (hex characters MUST be uppercase), sorted using lexicographic byte ordering.
         *       Parameter names are separated from their values by the '=' character
         *       (ASCII character 61), even if the value is empty.
         *       Pairs of parameter and values are separated by the '&' character (ASCII code 38).
         *
         */
        private string SignParameters(IDictionary<string, string> parameters, string key)
        {
            var signatureVersion = parameters["SignatureVersion"];

            KeyedHashAlgorithm algorithm = new HMACSHA1();

            string stringToSign = null;
            if ("2".Equals(signatureVersion))
            {
                var signatureMethod = _config.SignatureMethod;
                algorithm = new HMACSHA256();
                parameters.Add("SignatureMethod", signatureMethod);
                stringToSign = CalculateStringToSignV2(parameters);
            }
            else
            {
                throw new Exception("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private string CalculateStringToSignV2(IDictionary<string, string> parameters)
        {
            var data = new StringBuilder();
            IDictionary<string, string> sorted =
                  new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            data.Append("POST");
            data.Append("\n");
            var endpoint = new Uri(_config.ServiceURL.ToLower());

            data.Append(endpoint.Host);
            if (endpoint.Port != 443 && endpoint.Port != 80)
            {
                data.Append(":")
                    .Append(endpoint.Port);
            }

            data.Append("\n");
            var uri = endpoint.AbsolutePath;
            if (uri == null || uri.Length == 0)
            {
                uri = "/";
            }

            data.Append(UrlEncode(uri, true));
            data.Append("\n");
            foreach (var pair in sorted)
            {
                if (pair.Value != null)
                {
                    data.Append(UrlEncode(pair.Key, false));
                    data.Append("=");
                    data.Append(UrlEncode(pair.Value, false));
                    data.Append("&");
                }
            }

            var result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        private string UrlEncode(string data, bool path)
        {
            var encoded = new StringBuilder();
            var unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~" + (path ? "/" : "");

            foreach (char symbol in System.Text.Encoding.UTF8.GetBytes(data))
            {
                if (unreservedChars.IndexOf(symbol) != -1)
                {
                    encoded.Append(symbol);
                }
                else
                {
                    encoded.Append("%" + string.Format("{0:X2}", (int)symbol));
                }
            }

            return encoded.ToString();
        }

        /**
         * Computes RFC 2104-compliant HMAC signature.
         */
        private string Sign(string data, string key, KeyedHashAlgorithm algorithm)
        {
            Encoding encoding = new UTF8Encoding();
            algorithm.Key = encoding.GetBytes(key);
            return Convert.ToBase64String(algorithm.ComputeHash(
                encoding.GetBytes(data.ToCharArray())));
        }

        /**
         * Formats date as ISO 8601 timestamp
         */
        private string GetFormattedTimestamp(DateTime dt)
        {
            DateTime utcTime;
            if (dt.Kind == DateTimeKind.Local)
            {
                utcTime = new DateTime(
                    dt.Year,
                    dt.Month,
                    dt.Day,
                    dt.Hour,
                    dt.Minute,
                    dt.Second,
                    dt.Millisecond,
                    DateTimeKind.Local).ToUniversalTime();
            }
            else
            {
                // If DateTimeKind.Unspecified, assume UTC.
                utcTime = dt;
            }

            return utcTime.ToString("yyyy-MM-dd\\THH:mm:ss.fff\\Z", CultureInfo.InvariantCulture);
        }

        /**
         * Convert GetReportRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReport(GetReportRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReport" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportId())
            {
                parameters.Add("ReportId", request.ReportId);
            }

            return parameters;
        }

        /**
         * Convert GetReportScheduleCountRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportScheduleCount(GetReportScheduleCountRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportScheduleCount" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportTypeList())
            {
                var reportTypeList = request.ReportTypeList;
                var typeList = reportTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            return parameters;
        }

        /**
         * Convert GetReportRequestListByNextTokenRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportRequestListByNextToken(GetReportRequestListByNextTokenRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportRequestListByNextToken" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }

        /**
         * Convert UpdateReportAcknowledgementsRequest to name value pairs
         */
        private IDictionary<string, string> ConvertUpdateReportAcknowledgements(UpdateReportAcknowledgementsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "UpdateReportAcknowledgements" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportIdList())
            {
                var reportIdList = request.ReportIdList;
                var idList = reportIdList.Id;
                foreach (var id in idList)
                {
                    parameters.Add("ReportIdList" + "." + "Id" + "." + (idList.IndexOf(id) + 1), id);
                }
            }

            if (request.IsSetAcknowledged())
            {
                parameters.Add("Acknowledged", request.Acknowledged.ToString().ToLower());
            }

            return parameters;
        }

        /**
         * Convert SubmitFeedRequest to name value pairs
         */
        private IDictionary<string, string> ConvertSubmitFeed(SubmitFeedRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "SubmitFeed" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMarketplaceIdList())
            {
                var marketplaceIdList = request.MarketplaceIdList;
                var idList = marketplaceIdList.Id;
                var marketplaceIdListIndex = 1;
                foreach (var id in idList)
                {
                    parameters.Add("MarketplaceIdList.Id." + marketplaceIdListIndex, id);
                    marketplaceIdListIndex++;
                }
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetFeedType())
            {
                parameters.Add("FeedType", request.FeedType);
            }

            if (request.IsSetPurgeAndReplace())
            {
                parameters.Add("PurgeAndReplace", request.PurgeAndReplace.ToString().ToLower());
            }

            if (request.IsSetContentMD5())
            {
                parameters.Add("ContentMD5Value", request.ContentMD5);
            }

            return parameters;
        }

        /**
         * Convert GetReportCountRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportCount(GetReportCountRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportCount" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportTypeList())
            {
                var reportTypeList = request.ReportTypeList;
                var typeList = reportTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetAcknowledged())
            {
                parameters.Add("Acknowledged", request.Acknowledged.ToString().ToLower());
            }

            if (request.IsSetAvailableFromDate())
            {
                parameters.Add("AvailableFromDate", GetFormattedTimestamp(request.AvailableFromDate));
            }

            if (request.IsSetAvailableToDate())
            {
                parameters.Add("AvailableToDate", GetFormattedTimestamp(request.AvailableToDate));
            }

            return parameters;
        }

        /**
         * Convert GetFeedSubmissionListByNextTokenRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetFeedSubmissionListByNextToken(GetFeedSubmissionListByNextTokenRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetFeedSubmissionListByNextToken" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }

        /**
         * Convert CancelFeedSubmissionsRequest to name value pairs
         */
        private IDictionary<string, string> ConvertCancelFeedSubmissions(CancelFeedSubmissionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "CancelFeedSubmissions" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetFeedSubmissionIdList())
            {
                var feedSubmissionIdList = request.FeedSubmissionIdList;
                var idList = feedSubmissionIdList.Id;
                foreach (var id in idList)
                {
                    parameters.Add("FeedSubmissionIdList" + "." + "Id" + "." + (idList.IndexOf(id) + 1), id);
                }
            }

            if (request.IsSetFeedTypeList())
            {
                var feedTypeList = request.FeedTypeList;
                var typeList = feedTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("FeedTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetSubmittedFromDate())
            {
                parameters.Add("SubmittedFromDate", GetFormattedTimestamp(request.SubmittedFromDate));
            }

            if (request.IsSetSubmittedToDate())
            {
                parameters.Add("SubmittedToDate", GetFormattedTimestamp(request.SubmittedToDate));
            }

            return parameters;
        }

        /**
         * Convert RequestReportRequest to name value pairs
         */
        private IDictionary<string, string> ConvertRequestReport(RequestReportRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "RequestReport" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMarketplaceIdList())
            {
                var marketplaceIdList = request.MarketplaceIdList;
                var idList = marketplaceIdList.Id;
                var marketplaceIdListIndex = 1;
                foreach (var id in idList)
                {
                    parameters.Add("MarketplaceIdList.Id." + marketplaceIdListIndex, id);
                    marketplaceIdListIndex++;
                }
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportType())
            {
                parameters.Add("ReportType", request.ReportType);
            }

            if (request.IsSetStartDate())
            {
                parameters.Add("StartDate", GetFormattedTimestamp(request.StartDate));
            }

            if (request.IsSetEndDate())
            {
                parameters.Add("EndDate", GetFormattedTimestamp(request.EndDate));
            }

            if (request.IsSetReportOptions())
            {
                parameters.Add("ReportOptions", request.ReportOptions);
            }

            return parameters;
        }

        /**
         * Convert GetFeedSubmissionCountRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetFeedSubmissionCount(GetFeedSubmissionCountRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetFeedSubmissionCount" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetFeedTypeList())
            {
                var feedTypeList = request.FeedTypeList;
                var typeList = feedTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("FeedTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetFeedProcessingStatusList())
            {
                var feedProcessingStatusList = request.FeedProcessingStatusList;
                var statusList = feedProcessingStatusList.Status;
                foreach (var status in statusList)
                {
                    parameters.Add("FeedProcessingStatusList" + "." + "Status" + "." + (statusList.IndexOf(status) + 1), status);
                }
            }

            if (request.IsSetSubmittedFromDate())
            {
                parameters.Add("SubmittedFromDate", GetFormattedTimestamp(request.SubmittedFromDate));
            }

            if (request.IsSetSubmittedToDate())
            {
                parameters.Add("SubmittedToDate", GetFormattedTimestamp(request.SubmittedToDate));
            }

            return parameters;
        }

        /**
         * Convert CancelReportRequestsRequest to name value pairs
         */
        private IDictionary<string, string> ConvertCancelReportRequests(CancelReportRequestsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "CancelReportRequests" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportRequestIdList())
            {
                var reportRequestIdList = request.ReportRequestIdList;
                var idList = reportRequestIdList.Id;
                foreach (var id in idList)
                {
                    parameters.Add("ReportRequestIdList" + "." + "Id" + "." + (idList.IndexOf(id) + 1), id);
                }
            }

            if (request.IsSetReportTypeList())
            {
                var reportTypeList = request.ReportTypeList;
                var typeList = reportTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetReportProcessingStatusList())
            {
                var reportProcessingStatusList = request.ReportProcessingStatusList;
                var statusList = reportProcessingStatusList.Status;
                foreach (var status in statusList)
                {
                    parameters.Add("ReportProcessingStatusList" + "." + "Status" + "." + (statusList.IndexOf(status) + 1), status);
                }
            }

            if (request.IsSetRequestedFromDate())
            {
                parameters.Add("RequestedFromDate", GetFormattedTimestamp(request.RequestedFromDate));
            }

            if (request.IsSetRequestedToDate())
            {
                parameters.Add("RequestedToDate", GetFormattedTimestamp(request.RequestedToDate));
            }

            return parameters;
        }

        /**
         * Convert GetReportListRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportList(GetReportListRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportList" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetMaxCount())
            {
                parameters.Add("MaxCount", request.MaxCount + "");
            }

            if (request.IsSetReportTypeList())
            {
                var reportTypeList = request.ReportTypeList;
                var typeList = reportTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetAcknowledged())
            {
                parameters.Add("Acknowledged", request.Acknowledged.ToString().ToLower());
            }

            if (request.IsSetAvailableFromDate())
            {
                parameters.Add("AvailableFromDate", GetFormattedTimestamp(request.AvailableFromDate));
            }

            if (request.IsSetAvailableToDate())
            {
                parameters.Add("AvailableToDate", GetFormattedTimestamp(request.AvailableToDate));
            }

            if (request.IsSetReportRequestIdList())
            {
                var reportRequestIdList = request.ReportRequestIdList;
                var idList = reportRequestIdList.Id;
                foreach (var id in idList)
                {
                    parameters.Add("ReportRequestIdList" + "." + "Id" + "." + (idList.IndexOf(id) + 1), id);
                }
            }

            return parameters;
        }

        /**
         * Convert GetFeedSubmissionResultRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetFeedSubmissionResult(GetFeedSubmissionResultRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetFeedSubmissionResult" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetFeedSubmissionId())
            {
                parameters.Add("FeedSubmissionId", request.FeedSubmissionId);
            }

            return parameters;
        }

        /**
         * Convert GetFeedSubmissionListRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetFeedSubmissionList(GetFeedSubmissionListRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetFeedSubmissionList" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetFeedSubmissionIdList())
            {
                var feedSubmissionIdList = request.FeedSubmissionIdList;
                var idList = feedSubmissionIdList.Id;
                foreach (var id in idList)
                {
                    parameters.Add("FeedSubmissionIdList" + "." + "Id" + "." + (idList.IndexOf(id) + 1), id);
                }
            }

            if (request.IsSetMaxCount())
            {
                parameters.Add("MaxCount", request.MaxCount + "");
            }

            if (request.IsSetFeedTypeList())
            {
                var feedTypeList = request.FeedTypeList;
                var typeList = feedTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("FeedTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetFeedProcessingStatusList())
            {
                var feedProcessingStatusList = request.FeedProcessingStatusList;
                var statusList = feedProcessingStatusList.Status;
                foreach (var status in statusList)
                {
                    parameters.Add("FeedProcessingStatusList" + "." + "Status" + "." + (statusList.IndexOf(status) + 1), status);
                }
            }

            if (request.IsSetSubmittedFromDate())
            {
                parameters.Add("SubmittedFromDate", GetFormattedTimestamp(request.SubmittedFromDate));
            }

            if (request.IsSetSubmittedToDate())
            {
                parameters.Add("SubmittedToDate", GetFormattedTimestamp(request.SubmittedToDate));
            }

            return parameters;
        }

        /**
         * Convert GetReportRequestListRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportRequestList(GetReportRequestListRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportRequestList" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportRequestIdList())
            {
                var reportRequestIdList = request.ReportRequestIdList;
                var idList = reportRequestIdList.Id;
                foreach (var id in idList)
                {
                    parameters.Add("ReportRequestIdList" + "." + "Id" + "." + (idList.IndexOf(id) + 1), id);
                }
            }

            if (request.IsSetReportTypeList())
            {
                var reportTypeList = request.ReportTypeList;
                var typeList = reportTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetReportProcessingStatusList())
            {
                var reportProcessingStatusList = request.ReportProcessingStatusList;
                var statusList = reportProcessingStatusList.Status;
                foreach (var status in statusList)
                {
                    parameters.Add("ReportProcessingStatusList" + "." + "Status" + "." + (statusList.IndexOf(status) + 1), status);
                }
            }

            if (request.IsSetMaxCount())
            {
                parameters.Add("MaxCount", request.MaxCount + "");
            }

            if (request.IsSetRequestedFromDate())
            {
                parameters.Add("RequestedFromDate", GetFormattedTimestamp(request.RequestedFromDate));
            }

            if (request.IsSetRequestedToDate())
            {
                parameters.Add("RequestedToDate", GetFormattedTimestamp(request.RequestedToDate));
            }

            return parameters;
        }

        /**
         * Convert GetReportScheduleListByNextTokenRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportScheduleListByNextToken(GetReportScheduleListByNextTokenRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportScheduleListByNextToken" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }

        /**
         * Convert GetReportListByNextTokenRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportListByNextToken(GetReportListByNextTokenRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportListByNextToken" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }

        /**
         * Convert ManageReportScheduleRequest to name value pairs
         */
        private IDictionary<string, string> ConvertManageReportSchedule(ManageReportScheduleRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "ManageReportSchedule" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportType())
            {
                parameters.Add("ReportType", request.ReportType);
            }

            if (request.IsSetSchedule())
            {
                parameters.Add("Schedule", request.Schedule);
            }

            if (request.IsSetScheduleDate())
            {
                parameters.Add("ScheduleDate", GetFormattedTimestamp(request.ScheduleDate));
            }

            return parameters;
        }

        /**
         * Convert GetReportRequestCountRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportRequestCount(GetReportRequestCountRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportRequestCount" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportTypeList())
            {
                var reportTypeList = request.ReportTypeList;
                var typeList = reportTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            if (request.IsSetReportProcessingStatusList())
            {
                var reportProcessingStatusList = request.ReportProcessingStatusList;
                var statusList = reportProcessingStatusList.Status;
                foreach (var status in statusList)
                {
                    parameters.Add("ReportProcessingStatusList" + "." + "Status" + "." + (statusList.IndexOf(status) + 1), status);
                }
            }

            if (request.IsSetRequestedFromDate())
            {
                parameters.Add("RequestedFromDate", GetFormattedTimestamp(request.RequestedFromDate));
            }

            if (request.IsSetRequestedToDate())
            {
                parameters.Add("RequestedToDate", GetFormattedTimestamp(request.RequestedToDate));
            }

            return parameters;
        }

        /**
         * Convert GetReportScheduleListRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetReportScheduleList(GetReportScheduleListRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "Action", "GetReportScheduleList" }
            };
            if (request.IsSetMarketplace())
            {
                parameters.Add("Marketplace", request.Marketplace);
            }

            if (request.IsSetMerchant())
            {
                parameters.Add("Merchant", request.Merchant);
            }

            if (request.IsSetMWSAuthToken())
            {
                parameters.Add("MWSAuthToken", request.MWSAuthToken);
            }

            if (request.IsSetReportTypeList())
            {
                var reportTypeList = request.ReportTypeList;
                var typeList = reportTypeList.Type;
                foreach (var type in typeList)
                {
                    parameters.Add("ReportTypeList" + "." + "Type" + "." + (typeList.IndexOf(type) + 1), type);
                }
            }

            return parameters;
        }
    }
}

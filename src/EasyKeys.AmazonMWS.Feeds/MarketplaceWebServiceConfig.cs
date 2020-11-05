/*******************************************************************************
 *  Copyright 2008 Amazon Services.
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
 *  Generated: Mon Mar 16 15:13:52 PDT 2009
 *
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EasyKeys.AmazonMWS.Feeds
{
    /// <summary>
    /// Configuration for accessing Marketplace Web Service  service.
    /// </summary>
    public class MarketplaceWebServiceConfig
    {
        /// <summary>
        /// Gets and sets the request time-out value in milliseconds.
        /// </summary>
        public int RequestTimeout { get; set; } = 50000;

        /// <summary>
        /// Gets Service Version.
        /// </summary>
        public string ServiceVersion { get; } = "2009-01-01";

        /// <summary>
        /// Gets and sets of the signatureMethod property.
        /// </summary>
        public string SignatureMethod { get; set; } = "HmacSHA256";

        /// <summary>
        /// Sets the SignatureMethod property.
        /// </summary>
        /// <param name="signatureMethod">SignatureMethod property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceConfig WithSignatureMethod(string signatureMethod)
        {
            SignatureMethod = signatureMethod;
            return this;
        }

        /// <summary>
        /// Checks if SignatureMethod property is set.
        /// </summary>
        /// <returns>true if SignatureMethod property is set.</returns>
        public bool IsSetSignatureMethod()
        {
            return SignatureMethod != null;
        }

        /// <summary>
        /// Gets and sets of the SignatureVersion property.
        /// </summary>
        public string SignatureVersion { get; set; } = "2";

        /// <summary>
        /// Sets the SignatureVersion property.
        /// </summary>
        /// <param name="signatureVersion">SignatureVersion property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceConfig WithSignatureVersion(string signatureVersion)
        {
            SignatureVersion = signatureVersion;
            return this;
        }

        /// <summary>
        /// Checks if SignatureVersion property is set.
        /// </summary>
        /// <returns>true if SignatureVersion property is set.</returns>
        public bool IsSetSignatureVersion()
        {
            return SignatureVersion != null;
        }

        /// <summary>
        /// Gets and sets of the UserAgent property.
        /// </summary>
        public string UserAgent { get; private set; } = null;

        /// <summary>
        /// Sets the UserAgent property.
        /// </summary>
        /// <param name="userAgent">UserAgent property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceConfig WithUserAgent(string userAgent)
        {
            UserAgent = userAgent;
            return this;
        }

        /// <summary>
        /// Checks if UserAgent property is set.
        /// </summary>
        /// <returns>true if UserAgent property is set.</returns>
        public bool IsSetUserAgent()
        {
            return UserAgent != null;
        }

        /// <summary>
        /// Gets the ServiceURL property.
        /// </summary>
        public string ServiceURL { get; set; } = null;

        /// <summary>
        /// Sets the ServiceURL property.
        /// </summary>
        /// <param name="serviceURL">ServiceURL property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceConfig WithServiceURL(string serviceURL)
        {
            ServiceURL = serviceURL;
            return this;
        }

        /// <summary>
        /// Checks if ServiceURL property is set.
        /// </summary>
        /// <returns>true if ServiceURL property is set.</returns>
        public bool IsSetServiceURL()
        {
            return ServiceURL != null;
        }

        /// <summary>
        /// Gets and sets of the ProxyHost property.
        /// </summary>
        public string ProxyHost { get; set; } = null;

        /// <summary>
        /// Sets the ProxyHost property.
        /// </summary>
        /// <param name="proxyHost">ProxyHost property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceConfig WithProxyHost(string proxyHost)
        {
            ProxyHost = proxyHost;
            return this;
        }

        /// <summary>
        /// Checks if ProxyHost property is set.
        /// </summary>
        /// <returns>true if ProxyHost property is set.</returns>
        public bool IsSetProxyHost()
        {
            return ProxyHost != null;
        }

        /// <summary>
        /// Gets and sets of the ProxyPort property.
        /// </summary>
        public int ProxyPort { get; set; } = -1;

        /// <summary>
        /// Sets the ProxyPort property.
        /// </summary>
        /// <param name="proxyPort">ProxyPort property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceConfig WithProxyPort(int proxyPort)
        {
            ProxyPort = proxyPort;
            return this;
        }

        /// <summary>
        /// Checks if ProxyPort property is set.
        /// </summary>
        /// <returns>true if ProxyPort property is set.</returns>
        public bool IsSetProxyPort()
        {
            return ProxyPort != -1;
        }

        /// <summary>
        /// Gets and sets of the MaxErrorRetry property.
        /// </summary>
        public int MaxErrorRetry { get; set; } = 3;

        /// <summary>
        /// Sets the MaxErrorRetry property.
        /// </summary>
        /// <param name="maxErrorRetry">MaxErrorRetry property.</param>
        /// <returns>this instance.</returns>
        public MarketplaceWebServiceConfig WithMaxErrorRetry(int maxErrorRetry)
        {
            MaxErrorRetry = maxErrorRetry;
            return this;
        }

        /// <summary>
        /// Checks if MaxErrorRetry property is set.
        /// </summary>
        /// <returns>true if MaxErrorRetry property is set.</returns>
        public bool IsSetMaxErrorRetry()
        {
            return MaxErrorRetry != -1;
        }

        public void SetUserAgentHeader(
            string applicationName,
            string applicationVersion,
            string programmingLanguage,
            params string[] additionalNameValuePairs)
        {
            if (applicationName == null)
            {
                throw new ArgumentNullException("applicationName cannot be null.");
            }

            if (applicationVersion == null)
            {
                throw new ArgumentNullException("applicationVersion cannot be null.");
            }

            if (programmingLanguage == null)
            {
                throw new ArgumentNullException("programmingLanguage cannot be null.");
            }

            if (additionalNameValuePairs.Length % 2 != 0)
            {
                throw new ArgumentException("Every name must have a corresponding value.");
            }

            var sb = new StringBuilder();

            sb.Append(QuoteApplicationName(applicationName));
            sb.Append("/");
            sb.Append(QuoteApplicationVersion(applicationVersion));
            sb.Append(" (");
            sb.Append("Language=");
            sb.Append(QuoteAttributeValue(programmingLanguage));

            var i = 0;
            while (i < additionalNameValuePairs.Length)
            {
                var name = additionalNameValuePairs[i];
                var value = additionalNameValuePairs[++i];
                sb.Append("; ");
                sb.Append(QuoteAttributeName(name));
                sb.Append("=");
                sb.Append(QuoteAttributeValue(value));

                i++;
            }

            sb.Append(")");

            UserAgent = sb.ToString();
        }

        /// <summary>
        /// Replace all whitespace characters by a single space.
        /// </summary>
        /// <param name="s"></param>
        public static string Clean(string s)
        {
            // matched character sequences are passed to a MatchEvaluator
            // delegate. The returned string from the delegate replaces
            // the matched sequence.
            return Regex.Replace(s, @" {2,}|\s", delegate (Match m)
            {
                return " ";
            });
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// '\', and '/'.
        /// </summary>
        /// <param name="s"></param>
        public static string QuoteApplicationName(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace("@/", @"\/");
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// '\', and '('.
        /// </summary>
        /// <param name="s"></param>
        public static string QuoteApplicationVersion(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace(@"(", @"\(");
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// '\', and '='.
        /// </summary>
        /// <param name="s"></param>
        public static string QuoteAttributeName(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace(@"=", @"\=");
        }

        /// <summary>
        /// Collapse whitespace, and escape the following characters are escaped:
        /// ')', '\', and ';'.
        /// </summary>
        /// <param name="s"></param>
        public static string QuoteAttributeValue(string s)
        {
            return Clean(s).Replace(@"\", @"\\").Replace(@";", @"\;").Replace(@")", @"\)");
        }
    }
}

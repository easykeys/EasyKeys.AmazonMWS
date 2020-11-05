using System;

namespace EasyKeys.AmazonMWS.Feeds.Attributes
{
    [AttributeUsage(
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = false)]

    public class MarketplaceWebServiceRequestHeaderAttribute : Attribute
    {
        public MarketplaceWebServiceRequestHeaderAttribute(string headerName)
        {
            HeaderName = headerName;
        }

        public string HeaderName { get; set; }
    }
}

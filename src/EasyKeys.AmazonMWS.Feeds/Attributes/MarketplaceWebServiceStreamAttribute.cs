using System;

namespace EasyKeys.AmazonMWS.Feeds.Attributes
{
    [AttributeUsage(
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = false)]

    public class MarketplaceWebServiceStreamAttribute : Attribute
    {
        public StreamType StreamType { get; set; }
    }
}

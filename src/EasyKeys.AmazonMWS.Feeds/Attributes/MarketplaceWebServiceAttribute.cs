namespace EasyKeys.AmazonMWS.Feeds.Attributes
{
    using System;

    // create custom attribute to be assigned to class members
    [AttributeUsage(
       AttributeTargets.Class |
       AttributeTargets.Constructor |
       AttributeTargets.Field |
       AttributeTargets.Method |
       AttributeTargets.Property,
       AllowMultiple = true)]

    public class MarketplaceWebServiceAttribute : Attribute
    {
        public RequestType RequestType { get; set; }

        public ResponseType ResponseType { get; set; }

        public bool IsReceiveStream { get; set; }

        public bool IsRequestStream { get; set; }
    }
}

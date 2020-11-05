using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EasyKeys.AmazonMWS.Feeds.Model
{
    /// <summary>
    /// Defines the content type, encoding, and character set used to
    /// send a feed to MWS.
    /// </summary>
    public class ContentType
    {
        private List<IContentTypeParameter> _parameters = new List<IContentTypeParameter>();

        /// <summary>
        /// Gets or sets the type of content.  This value defaults
        /// to "FeedContentType.OctetStream".
        /// </summary>
        public MediaType Type { get; } = MediaType.OctetStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentType"/> class.
        /// Creates a new instance of the ContentType object with the specified values.
        /// </summary>
        public ContentType(MediaType contentType)
        {
            Type = contentType;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            // Pick the "Description" attribute off the specified enum value.  This will throw an exception
            // if the attribute is not present or the enum value is not valid.
            var descAttributes = typeof(MediaType).GetField(Type.ToString(), BindingFlags.Static | BindingFlags.GetField | BindingFlags.Public)
                .GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            foreach (System.ComponentModel.DescriptionAttribute descAttribute in descAttributes)
            {
                sb.Append(descAttribute.Description);
                foreach (var param in _parameters)
                {
                    sb.Append(";" + param.ToString());
                }

                return sb.ToString();
            }

            return string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentType"/> class.
        /// Creates a new instance of the ContentType object with the default values.
        /// </summary>
        private ContentType()
        {
        }

        private void AddParameter(IContentTypeParameter parameter)
        {
            _parameters.Add(parameter);
        }
    }
}

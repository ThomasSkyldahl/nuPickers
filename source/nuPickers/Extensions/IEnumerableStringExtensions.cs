using Umbraco.Core.Models.PublishedContent;

namespace nuPickers.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Umbraco.Web;

    internal static class IEnumerableStringExtensions
    {
        /// <summary>
        /// TODO: migrate out of Picker obj
        /// parse a collection of strings, and attempt to return a collection of IPublishedContent
        /// </summary>
        /// <param name="keys"></param>
        /// <returns>a collection (populated, or empty)</returns>
        internal static IEnumerable<IPublishedContent> AsPublishedContent(this IEnumerable<string> keys)
        {
            var umbracoHelper = Umbraco.Web.Composing.Current.UmbracoHelper;

            return keys
                    .Select(x => umbracoHelper.GetPublishedContent(x))
                    .Where(x => x != null);
        }
    }
}
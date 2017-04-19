namespace Sitecore.Feature.Metadata.Repositories
{
    using System.Linq;
    using Sitecore.Feature.Metadata.Models;
    using Fortis.Foundation.CodeGen.Templates.Feature.Metadata;

    public static class MetadataRepository
    {
        public static ISiteMetadata Get(IPageMetadata contextItem)
        {
            return contextItem.AncestorOrSelf<ISiteMetadata>();
        }

        public static MetaKeywordsModel GetKeywords(IPageMetadata item)
        {
            if (item?.MetaKeywords.Value == null)
            {
                return null;
            }

            var keywords = item.MetaKeywords.GetItems<IKeyword>()?.Select(k=> k.Keyword.Value);
            var metaKeywordModel = new MetaKeywordsModel
            {
                Keywords = keywords
            };

            return metaKeywordModel;
        }
    }
}
namespace Sitecore.Feature.Metadata.Repositories
{
    using System.Linq;
    using Sitecore.Feature.Metadata.Models;
    using PageMetadata = Fortis.Foundation.CodeGen.Templates.Feature.Metadata.PageMetadata;
    using SiteMetadata = Fortis.Foundation.CodeGen.Templates.Feature.Metadata.SiteMetadata;
    using Keyword = Fortis.Foundation.CodeGen.Templates.Feature.Metadata.Keyword;

    public static class MetadataRepository
    {
        public static SiteMetadata.ISiteMetadata Get(PageMetadata.IPageMetadata contextItem)
        {
            return contextItem.AncestorOrSelf<SiteMetadata.ISiteMetadata>();
        }

        public static MetaKeywordsModel GetKeywords(PageMetadata.IPageMetadata item)
        {
            if (item?.MetaKeywords.Value == null)
            {
                return null;
            }

            var keywords = item.MetaKeywords.GetItems<Keyword.IKeyword>()?.Select(k=> k.Keyword.Value);
            var metaKeywordModel = new MetaKeywordsModel
            {
                Keywords = keywords
            };

            return metaKeywordModel;
        }
    }
}
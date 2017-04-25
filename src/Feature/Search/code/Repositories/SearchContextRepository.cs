namespace Sitecore.Feature.Search.Repositories
{
    using System.Web;
    using Sitecore.Data.Items;
    using Sitecore.Feature.Search.Models;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.Mvc.Presentation;
    using Fortis.Foundation.CodeGen.Templates.Feature.Search;

    public class SearchContextRepository : ISearchContextRepository
    {
        private const string DefaultSearchResultsName = "search";

        public virtual SearchContext Get()
        {
            var query = HttpContext.Current == null ? "" : HttpContext.Current.Request["query"];

            var searchResultsPageItem = GetSearchResultsPageItem();
            if (searchResultsPageItem == null)
                return null;
            return new SearchContext
            {
                ConfigurationItem = searchResultsPageItem,
                Query = query,
                SearchBoxTitle = searchResultsPageItem[SearchResultsConstants.Fields.SearchBoxTitle.ID],
                SearchResultsUrl = searchResultsPageItem.Url(),
                Root = this.GetRootItem(searchResultsPageItem)
            };
        }

        private static Item GetSearchResultsPageItem()
        {
            return GetSearchResultsPageItemFromRenderingContext() ??
                   GetSearchResultsPageItemFromContext() ??
                   GetDefaultSearchResultsPage();
        }

        private static Item GetDefaultSearchResultsPage()
        {
            var item = Context.Site?.GetStartItem().Children[DefaultSearchResultsName];
            return item != null && item.IsDerived(SearchResultsConstants.TemplateID) ? item : null;
        }

        private static Item GetSearchResultsPageItemFromContext()
        {
            var item = Context.Item?.GetAncestorOrSelfOfTemplate(SearchContextConstants.TemplateID) ?? Context.Site?.GetContextItem(SearchContextConstants.TemplateID);
            if (item == null)
                return null;
            var searchResultsItem = item.TargetItem(SearchContextConstants.Fields.SearchResultsPage.ID);
            return searchResultsItem != null && searchResultsItem.IsDerived(SearchResultsConstants.TemplateID) ? searchResultsItem : null;
        }

        private static Item GetSearchResultsPageItemFromRenderingContext()
        {
            var item = RenderingContext.Current?.Rendering.Item;
            return item != null && item.IsDerived(SearchResultsConstants.TemplateID) ? item : null;
        }

        private Item GetRootItem(Item configurationItem)
        {
            Item rootItem = null;
            if (configurationItem.FieldHasValue(SearchResultsConstants.Fields.Root.ID))
            {
                rootItem = configurationItem.TargetItem(SearchResultsConstants.Fields.Root.ID);
            }
            return rootItem ?? Context.Site.GetRootItem();
        }
    }
}
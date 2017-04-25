namespace Sitecore.Feature.News.Indexing
{
    using System;
    using System.Collections.Generic;
    using System.Configuration.Provider;
    using System.Linq.Expressions;
    using Sitecore.ContentSearch.SearchTypes;
    using Sitecore.Data;
    using Sitecore.Foundation.Dictionary.Repositories;
    using Sitecore.Foundation.Indexing.Infrastructure;
    using Sitecore.Foundation.Indexing.Models;
    using Sitecore.Web.UI.WebControls;
    using Fortis.Foundation.CodeGen.Templates.Feature.News;

    public class NewsIndexingProvider : ProviderBase, ISearchResultFormatter, IQueryPredicateProvider
    {
        public string ContentType => DictionaryPhraseRepository.Current.Get("/News/Search/Content Type", "News");

        public IEnumerable<ID> SupportedTemplates => new[] { NewsArticleConstants.TemplateID };

        public Expression<Func<SearchResultItem, bool>> GetQueryPredicate(IQuery query)
        {
            var fieldNames = new[] { NewsArticleConstants.Fields.NewsTitle.FieldName, NewsArticleConstants.Fields.NewsSummary.FieldName, NewsArticleConstants.Fields.NewsBody.FieldName};
            return GetFreeTextPredicateService.GetFreeTextPredicate(fieldNames, query);
        }

        public void FormatResult(SearchResultItem item, ISearchResult formattedResult)
        {
            var contentItem = item.GetItem();
            if (contentItem != null)
            {
                formattedResult.Title = FieldRenderer.Render(contentItem, NewsArticleConstants.Fields.NewsTitle.ID.ToString());
                formattedResult.Description = FieldRenderer.Render(contentItem, NewsArticleConstants.Fields.NewsSummary.ID.ToString());
                formattedResult.ViewName = "~/Views/News/NewsSearchResult.cshtml";
            }
        }
    }
}
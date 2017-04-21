namespace Sitecore.Feature.PageContent.Indexing
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
  using Fortis.Foundation.CodeGen.Templates.Feature.PageContent;

  public class PageContentIndexingProvider : ProviderBase, ISearchResultFormatter, IQueryPredicateProvider
  {
    public  string ContentType => DictionaryPhraseRepository.Current.Get("/Page Content/Search/Content Type", "Page");

    public IEnumerable<ID> SupportedTemplates => new[]
    {
      HasPageContentConstants.TemplateID
    };

    public Expression<Func<SearchResultItem, bool>> GetQueryPredicate(IQuery query)
    {
      var fieldNames = new[] {
          HasPageContentConstants.Fields.Title.FieldName,
          HasPageContentConstants.Fields.Summary.FieldName,
          HasPageContentConstants.Fields.Body.FieldName
      };
      return GetFreeTextPredicateService.GetFreeTextPredicate(fieldNames, query);
    }

    public void FormatResult(SearchResultItem item, ISearchResult formattedResult)
    {
      var contentItem = item.GetItem();
      formattedResult.Title = FieldRenderer.Render(contentItem, HasPageContentConstants.Fields.Title.FieldName);
      formattedResult.Description = FieldRenderer.Render(contentItem, HasPageContentConstants.Fields.Summary.FieldName);
    }
  }
}
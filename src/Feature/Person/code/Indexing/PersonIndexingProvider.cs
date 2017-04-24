namespace Sitecore.Feature.Person.Indexing
{
    using System;
    using System.Collections.Generic;
    using System.Configuration.Provider;
    using System.Linq.Expressions;
    using Sitecore.ContentSearch.SearchTypes;
    using Sitecore.Data;
    using Sitecore.Foundation.Indexing.Infrastructure;
    using Sitecore.Foundation.Indexing.Models;
    using Sitecore.Foundation.SitecoreExtensions.Repositories;
    using Sitecore.Web.UI.WebControls;
    using Foundation.Dictionary.Repositories;
    using Fortis.Foundation.CodeGen.Templates.Feature.Person;

    public class PersonIndexingProvider : ProviderBase, ISearchResultFormatter, IQueryPredicateProvider
    {
        public string ContentType => DictionaryPhraseRepository.Current.Get("/Person/Search/Content Type", "Employee");

        public IEnumerable<ID> SupportedTemplates => new[]
        {
            EmployeeConstants.TemplateID
        };

        public Expression<Func<SearchResultItem, bool>> GetQueryPredicate(IQuery query)
        {
            var fieldNames = new[]
            {
                PersonConstants.Fields.Title.FieldName,
                PersonConstants.Fields.Summary.FieldName,
                PersonConstants.Fields.Name.FieldName,
                EmployeeConstants.Fields.Biography.FieldName
            };
            return GetFreeTextPredicateService.GetFreeTextPredicate(fieldNames, query);
        }

        public void FormatResult(SearchResultItem item, ISearchResult formattedResult)
        {
            var contentItem = item.GetItem();
            formattedResult.Title = FieldRenderer.Render(contentItem, PersonConstants.Fields.Name.ID.ToString());
            formattedResult.Description = FieldRenderer.Render(contentItem, PersonConstants.Fields.Summary.ID.ToString());
            formattedResult.ViewName = "~/Views/Person/EmployeeSearchResult.cshtml";
        }
    }
}
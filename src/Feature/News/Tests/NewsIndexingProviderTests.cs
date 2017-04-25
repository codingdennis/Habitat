namespace Sitecore.Feature.News.Tests
{
    using FluentAssertions;
    using NSubstitute;
    using Sitecore.Feature.News.Tests.Extensions;
    using Xunit;
    using Sitecore.Collections;
    using Sitecore.ContentSearch.SearchTypes;
    using Sitecore.Data.Items;
    using Sitecore.FakeDb.AutoFixture;
    using Sitecore.FakeDb.Sites;
    using Sitecore.Feature.News.Indexing;
    using Sitecore.Foundation.Indexing.Models;
    using Fortis.Foundation.CodeGen.Templates.Feature.News;

    public class NewsIndexingProviderTests
    {
        [Theory]
        [AutoDbData]
        public void ContentType_ShouldBeNews(NewsIndexingProvider provider, [Content] Item dictionaryRoot)
        {
            Context.Site = new FakeSiteContext(new StringDictionary()
            {
                ["dictionaryPath"] = dictionaryRoot.Paths.FullPath,
                ["database"] = "master"
            });
            provider.ContentType.Should().Be("News");
        }

        [Theory]
        [AutoDbData]
        public void SupportedTemplates_ContainsNewsArticleTemplate(NewsIndexingProvider provider)
        {
            provider.SupportedTemplates.Should().Contain(NewsArticleConstants.TemplateID);
        }

        [Theory]
        [AutoDbData]
        public void GetQueryPredicate_WrongTemplate_ShouldReturnFalse(NewsIndexingProvider provider, IQuery query)
        {
            provider.GetQueryPredicate(query).Compile().Invoke(new SearchResultItem()).Should().BeFalse();
        }


        [Theory]
        [InlineAutoDbData(NewsArticleConstants.Fields.NewsTitle.FieldName)]
        [InlineAutoDbData(NewsArticleConstants.Fields.NewsBody.FieldName)]
        [InlineAutoDbData(NewsArticleConstants.Fields.NewsSummary.FieldName)]
        public void GetQueryPredicate_NewsItemWithSearchContent_ShouldReturnTrue(string fieldName, NewsIndexingProvider provider, IQuery query, string queryText)
        {
            var item = Substitute.For<SearchResultItem>();
            query.QueryText.Returns(queryText);
            item[fieldName].Returns(queryText);
            provider.GetQueryPredicate(query).Compile().Invoke(item).Should().BeTrue();
        }

        [Theory]
        [InlineAutoDbData(NewsArticleConstants.Fields.NewsTitle.FieldName)]
        [InlineAutoDbData(NewsArticleConstants.Fields.NewsBody.FieldName)]
        [InlineAutoDbData(NewsArticleConstants.Fields.NewsSummary.FieldName)]
        public void GetQueryPredicate_NewsItemWithWrongContent_ShouldReturnFalse(string fieldName, NewsIndexingProvider provider, IQuery query, string queryText, string contentText)
        {
            var item = Substitute.For<SearchResultItem>();
            query.QueryText.Returns(queryText);
            item[fieldName].Returns(contentText);
            provider.GetQueryPredicate(query).Compile().Invoke(item).Should().BeFalse();
        }
    }
}
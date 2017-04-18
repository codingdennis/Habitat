namespace Sitecore.Feature.Metadata.Tests
{
    using System.Linq;
    using FluentAssertions;
    using Sitecore.Data;
    using Sitecore.FakeDb;
    using Sitecore.Feature.Metadata.Models;
    using Sitecore.Feature.Metadata.Repositories;
    using Sitecore.Foundation.Testing.Attributes;
    using Xunit;
    using PageMetadata = Fortis.Foundation.CodeGen.Templates.Feature.Metadata.PageMetadata;
    using SiteMetadata = Fortis.Foundation.CodeGen.Templates.Feature.Metadata.SiteMetadata;
    using KeywordAlias = Fortis.Foundation.CodeGen.Templates.Feature.Metadata.Keyword;
    using Fortis.Model;
    using Fortis.Mvc.Providers;
    using Fortis.Providers;
    using Moq;
    using Sitecore.Analytics.Rules.Conditions;
    using Sitecore.Data.Items;
    using Sitecore.FakeDb.AutoFixture;

    public class MetadataRepositoryTests
    {
        [Theory]
        [AutoDbData]
        public void GetKeywords_ContextItem_ShouldReturnKeywordsModel(Db db, string contextItemName, string keyword1ItemName, string keyword2ItemName)
        {
            var contextItemId = ID.NewID;
            var keyword1Id = ID.NewID;
            var keyword2Id = ID.NewID;

            db.Add(new DbItem(contextItemName, contextItemId, PageMetadata.Static.ID)
                {
                   new DbField(PageMetadata.Static.Fields.MetaKeywords.FieldName)
                   {
                     {"en", $"{keyword1Id}|{keyword2Id}"}
                   }
                }
            );

            db.Add(new DbItem(keyword1ItemName, keyword1Id, KeywordAlias.Static.ID)
                {
                    new DbField(KeywordAlias.Static.Fields.Keyword.FieldName)
                    {
                        {"en", keyword1ItemName}
                    }
                }
            );

            db.Add(new DbItem(keyword2ItemName, keyword2Id, KeywordAlias.Static.ID)
                {
                    new DbField(KeywordAlias.Static.Fields.Keyword.FieldName)
                    {
                        {"en", keyword2ItemName}
                    }
                }
            );

            var itemFactory = this.GetItemFactory();
            var model = itemFactory.Select<PageMetadata.IPageMetadata>(contextItemId.Guid);

            var keywordsModel = MetadataRepository.GetKeywords(model);
            keywordsModel.Should().BeOfType<MetaKeywordsModel>();
            keywordsModel.Keywords.Count().Should().Be(2);
        }

        [Theory]
        [AutoDbData]
        public void Get_ContextItemIsMatchingTemplate_ShouldReturnSelf(Db db, string contextItemName)
        {
            var contextItemId = ID.NewID;

            db.Add(new DbItem(contextItemName, contextItemId, PageMetadata.Static.ID));

            var itemFactory = this.GetItemFactory();
            var contextItem = itemFactory.Select<PageMetadata.IPageMetadata>(contextItemId.Guid);
            contextItem.ItemID.Should().Be(contextItemId.Guid);
        }

        [Theory]
        [AutoDbData]
        public void Get_ContextItemParentIsMatchingTemplate_ShouldReturnParent(Db db)
        {
            var contextItemId = ID.NewID;

            db.Add(new DbItem("context", contextItemId, SiteMetadata.Static.ID));
            var contextItem = db.GetItem(contextItemId);
            var child = contextItem.Add("child", new TemplateID(PageMetadata.Static.ID));
            var itemFactory = this.GetItemFactory();
            var keywordsModel = MetadataRepository.Get(itemFactory.Select<PageMetadata.IPageMetadata>(child.ID.Guid));

            keywordsModel.ItemID.Should().Be(contextItemId.Guid);
        }

        private IItemFactory GetItemFactory()
        {
            var contextProvider = new ContextProvider();
            var spawnProvider = new SpawnProvider(new TemplateMapProvider(new ModelAssemblyProvider()));
            return new ItemFactory(contextProvider, spawnProvider);
        }
    }
}
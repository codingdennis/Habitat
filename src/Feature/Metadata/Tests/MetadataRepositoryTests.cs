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
    using Fortis.Foundation.CodeGen.Templates.Feature.Metadata;
    using Fortis.Model;
    using Fortis.Mvc.Providers;
    using Fortis.Providers;

    public class MetadataRepositoryTests
    {
        [Theory]
        [AutoDbData]
        public void GetKeywords_ContextItem_ShouldReturnKeywordsModel(Db db, string contextItemName, string keyword1ItemName, string keyword2ItemName)
        {
            var contextItemId = ID.NewID;
            var keyword1Id = ID.NewID;
            var keyword2Id = ID.NewID;

            db.Add(new DbItem(contextItemName, contextItemId, PageMetadataItemConstants.TemplateID)
                {
                   new DbField(PageMetadataItemConstants.Fields.MetaKeywords.FieldName)
                   {
                     {"en", $"{keyword1Id}|{keyword2Id}"}
                   }
                }
            );

            db.Add(new DbItem(keyword1ItemName, keyword1Id, KeywordItemConstants.TemplateID)
                {
                    new DbField(KeywordItemConstants.Fields.Keyword.FieldName)
                    {
                        {"en", keyword1ItemName}
                    }
                }
            );

            db.Add(new DbItem(keyword2ItemName, keyword2Id, KeywordItemConstants.TemplateID)
                {
                    new DbField(KeywordItemConstants.Fields.Keyword.FieldName)
                    {
                        {"en", keyword2ItemName}
                    }
                }
            );

            var itemFactory = this.GetItemFactory();
            var model = itemFactory.Select<IPageMetadata>(contextItemId.Guid);

            var keywordsModel = MetadataRepository.GetKeywords(model);
            keywordsModel.Should().BeOfType<MetaKeywordsModel>();
            keywordsModel.Keywords.Count().Should().Be(2);
        }

        [Theory]
        [AutoDbData]
        public void Get_ContextItemIsMatchingTemplate_ShouldReturnSelf(Db db, string contextItemName)
        {
            var contextItemId = ID.NewID;

            db.Add(new DbItem(contextItemName, contextItemId, PageMetadataItemConstants.TemplateID));

            var itemFactory = this.GetItemFactory();
            var contextItem = itemFactory.Select<IPageMetadata>(contextItemId.Guid);
            contextItem.ItemID.Should().Be(contextItemId.Guid);
        }

        [Theory]
        [AutoDbData]
        public void Get_ContextItemParentIsMatchingTemplate_ShouldReturnParent(Db db)
        {
            var contextItemId = ID.NewID;

            db.Add(new DbItem("context", contextItemId, SiteMetadataItemConstants.TemplateID));
            var contextItem = db.GetItem(contextItemId);
            var child = contextItem.Add("child", new TemplateID(PageMetadataItemConstants.TemplateID));
            var itemFactory = this.GetItemFactory();
            var keywordsModel = MetadataRepository.Get(itemFactory.Select<IPageMetadata>(child.ID.Guid));

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
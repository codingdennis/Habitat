namespace Sitecore.Feature.Metadata.Tests
{
    using System;
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
    using Moq;

    public class MetadataRepositoryTests
    {
        [Theory]
        [AutoDbData]
        public void GetKeywords_ContextItem_ShouldReturnKeywordsModel(Db db, string contextItemName, string keyword1ItemName, string keyword2ItemName)
        {
            var contextItemId = ID.NewID;
            var keyword1Id = ID.NewID;
            var keyword2Id = ID.NewID;

            db.Add(new DbItem(contextItemName, contextItemId, PageMetadataConstants.TemplateID)
                {
                   new DbField(PageMetadataConstants.Fields.MetaKeywords.FieldName)
                   {
                     {"en", $"{keyword1Id}|{keyword2Id}"}
                   }
                }
            );

            db.Add(new DbItem(keyword1ItemName, keyword1Id, KeywordConstants.TemplateID)
                {
                    new DbField(KeywordConstants.Fields.Keyword.FieldName)
                    {
                        {"en", keyword1ItemName}
                    }
                }
            );

            db.Add(new DbItem(keyword2ItemName, keyword2Id, KeywordConstants.TemplateID)
                {
                    new DbField(KeywordConstants.Fields.Keyword.FieldName)
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

            db.Add(new DbItem(contextItemName, contextItemId, PageMetadataConstants.TemplateID));

            var itemFactory = this.GetItemFactory();
            var contextItem = itemFactory.Select<IPageMetadata>(contextItemId.Guid);
            contextItem.ItemID.Should().Be(contextItemId.Guid);
        }

        [Fact]
        public void Get_ContextItemParentIsMatchingTemplate_ShouldReturnParent()
        {
            var parent = new Mock<ISiteMetadata>();
            var newID = Guid.NewGuid();
            parent.Setup(x => x.ItemID).Returns(newID);

            var item = new Mock<IPageMetadata>();
            item.Setup(x => x.ItemID).Returns(newID);
            item.Setup(x => x.AncestorOrSelf<ISiteMetadata>()).Returns(parent.Object);
            
            var keywordsModel = MetadataRepository.Get(item.Object);
            keywordsModel.ItemID.Should().Be(newID);
        }

        private IItemFactory GetItemFactory()
        {
            var contextProvider = new ContextProvider();
            var spawnProvider = new SpawnProvider(new TemplateMapProvider(new ModelAssemblyProvider()));
            return new ItemFactory(contextProvider, spawnProvider);
        }
    }
}
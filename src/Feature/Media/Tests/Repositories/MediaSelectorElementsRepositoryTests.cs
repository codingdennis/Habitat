namespace Sitecore.Feature.Media.Tests.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Fortis.Foundation.CodeGen.Templates.Feature.Media;
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.FakeDb;
    using Sitecore.FakeDb.AutoFixture;
    using Sitecore.Feature.Media.Repositories;
    using Sitecore.Feature.Media.Tests.Infrastructure;
    using Sitecore.Foundation.Testing.Attributes;
    using Xunit;
    using Fortis.Foundation.CodeGen.Templates.Project.Common.ContentTypes.Media;
    using Fortis.Foundation.CustomWrappers;
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using Moq;
    
    public class MediaSelectorElementsRepositoryTests
    {
        [Theory]
        [AutoDbData]
        public void Get_NoItemsInRepo_ShouldReturnEmpty([Content] ICarousel item)
        {
            // substitute the original provider with the mocked one
            MediaSelectorElementsRepository.Get(item).Count().Should().Be(0);
        }

        [Fact]
        public void Get_NoVideoItemsInRepo_ShouldReturnEmpty()
        {
            var parentMock = new Mock<ICarousel>();

            var listFieldMock = new Mock<IListFieldWrapper>();
            listFieldMock.Setup(x => x.GetItems<ICustomItemWrapper>()).Returns(() => null);

            parentMock.Setup(x => x.MediaSelector).Returns(listFieldMock.Object);

            var childMock = new Mock<IHasMediaVideo>();
            childMock.Setup(x => x.TemplateId).Returns(HasMediaVideoItemConstants.TemplateID.Guid);

            parentMock.Setup(x => x.Children<ICustomItemWrapper>(false)).Returns(
                () => new[] {childMock.Object}
            );

            MediaSelectorElementsRepository.Get(parentMock.Object).Count().Should().Be(0);
        }

        [Fact]
        public void Get_ValidVideoLinksItems_ShouldReturnItems()
        {
            var childVideoId = Guid.NewGuid();
            var childVideoMock = new Mock<IHasMediaVideo>();

            childVideoMock.Setup(x => x.ItemID).Returns(childVideoId);
            childVideoMock.Setup(x => x.MediaVideoLink).Returns(() =>
            {
                var linkMock = new Mock<ICustomGeneralLinkFieldWrapper>();
                linkMock.Setup(l => l.HasValue).Returns(true);
                linkMock.Setup(l => l.RawValue).Returns("videoLink");
                return linkMock.Object;
            });
            
            var carouselMock = new Mock<ICarousel>();
            carouselMock.Setup(x => x.MediaSelector.GetItems<ICustomItemWrapper>()).Returns(
                () => new[] {childVideoMock.Object}
            );

            //// substitute the original provider with the mocked one
            var carouselElements = MediaSelectorElementsRepository.Get(carouselMock.Object).ToList();
            carouselElements.Count.Should().Be(1);
            carouselElements.First().Item.ItemID.Should().Be(childVideoId);
            (carouselElements.First().Item as IHasMediaVideo)?.MediaVideoLink.RawValue.Should().Be("videoLink");
        }

        [Fact]
        public void Get_VideoLinkWithThumbnail_ShouldReturnCollection()
        {
            var childMediaId = Guid.NewGuid();
            var childMediaMock = new Mock<IHasMedia>();

            childMediaMock.Setup(x => x.ItemID).Returns(childMediaId);
            childMediaMock.Setup(x => x.MediaThumbnail).Returns(() =>
            {
                var thumbnailMock = new Mock<ICustomImageFieldWrapper>();
                thumbnailMock.Setup(l => l.HasValue).Returns(true);
                thumbnailMock.Setup(l => l.RawValue).Returns("thumbnail");
                return thumbnailMock.Object;
            });

            var carouselMock = new Mock<ICarousel>();
            carouselMock.Setup(x => x.MediaSelector.GetItems<ICustomItemWrapper>()).Returns(
                () => new[] { childMediaMock.Object }
            );

            // substitute the original provider with the mocked one
            var carouselElements = MediaSelectorElementsRepository.Get(carouselMock.Object).ToList();
            carouselElements.Count.Should().Be(1);
            carouselElements.First().Item.ItemID.Should().Be(childMediaId);
            (carouselElements.First().Item as IHasMedia)?.MediaThumbnail.RawValue.Should().Be("thumbnail");
        }


        [Fact]
        public void Get_EmptyVideoLinksItems_ShouldSkip()
        {
            var childMediaMock = new Mock<IHasMediaVideo>();
            childMediaMock.Setup(x => x.MediaVideoLink.HasValue).Returns(false);
            childMediaMock.Setup(x => x.MediaThumbnail.HasValue).Returns(false);

            var carouselMock = new Mock<ICarousel>();
            carouselMock.Setup(x => x.MediaSelector.GetItems<ICustomItemWrapper>()).Returns(
                () => new[] { childMediaMock.Object }
            );

            // substitute the original provider with the mocked one
            var carouselElements = MediaSelectorElementsRepository.Get(carouselMock.Object);
            carouselElements.Count().Should().Be(0);
        }
    }
}
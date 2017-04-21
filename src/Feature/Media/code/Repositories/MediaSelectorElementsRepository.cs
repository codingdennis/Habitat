namespace Sitecore.Feature.Media.Repositories
{
    using System;
    using System.Collections.Generic;
    using Fortis.Foundation.CodeGen.Templates.Feature.Media;
    using Fortis.Foundation.CodeGen.Templates.Project.Common.ContentTypes.Media;
    using Fortis.Foundation.CustomWrappers;
    using Models;

    public static class MediaSelectorElementsRepository
    {
        public static IEnumerable<MediaSelectorElement> Get([NotNull] ICarousel item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            var items = item.MediaSelector.GetItems<ICustomItemWrapper>() ?? item.Children<IHasMedia>();
            var active = "active";

            foreach (var child in items)
            {
                var videoChild = child as IHasMediaVideo;

                if (videoChild != null && !(videoChild.MediaVideoLink.HasValue || videoChild.MediaThumbnail.HasValue))
                {
                    continue;
                }

                yield return new MediaSelectorElement()
                {
                    Item = child,
                    Active = active
                };

                active = "";
            }
        }
    }
}
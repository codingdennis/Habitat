namespace Sitecore.Feature.Maps.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Foundation.SitecoreExtensions.Extensions;
    using Fortis.Foundation.CodeGen.Templates.Feature.Maps;

    public class MapPointRepository : IMapPointRepository
    {
        private readonly Foundation.Indexing.Repositories.ISearchServiceRepository searchServiceRepository;

        public MapPointRepository() : this(new Foundation.Indexing.Repositories.SearchServiceRepository(new Foundation.Indexing.Models.SearchSettingsBase {Templates = new[] {MapPointItemConstants.TemplateID}}))
        {
        }

        public MapPointRepository(Foundation.Indexing.Repositories.ISearchServiceRepository searchServiceRepository)
        {
            this.searchServiceRepository = searchServiceRepository;
        }

        public IEnumerable<MapPoint> GetAll(Data.Items.Item contextItem)
        {
            if (contextItem == null)
            {
                throw new ArgumentNullException(nameof(contextItem));
            }
            if (contextItem.IsDerived(MapPointItemConstants.TemplateID))
            {
                return new List<MapPoint>
                {
                    new MapPoint(contextItem)
                };
            }
            if (!contextItem.IsDerived(MapPointsFolderItemConstants.TemplateID))
            {
                throw new ArgumentException("Item must derive from MapPointsFolder or MapPoint", nameof(contextItem));
            }

            var searchService = this.searchServiceRepository.Get();
            searchService.Settings.Root = contextItem;

            return searchService.FindAll().Results.Select(x => new MapPoint(x.Item));
        }
    }
}
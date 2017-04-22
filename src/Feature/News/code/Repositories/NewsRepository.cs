namespace Sitecore.Feature.News.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.Indexing.Models;
    using Sitecore.Foundation.Indexing.Repositories;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using System.Web.Mvc;
    using Fortis.Model;
    using Fortis.Foundation.CodeGen.Templates.Feature.News;

    public class NewsRepository : INewsRepository
    {
        public Item ContextItem { get; set; }

        private readonly ISearchServiceRepository _searchServiceRepository;

        public NewsRepository(Item contextItem) : this(contextItem, new SearchServiceRepository(new SearchSettingsBase { Templates = new[] { NewsArticleConstants.TemplateID } }))
        {
        }

        public NewsRepository(Item contextItem, ISearchServiceRepository searchServiceRepository)
        {
            if (contextItem == null)
            {
                throw new ArgumentNullException(nameof(contextItem));
            }
            if (!contextItem.IsDerived(NewsFolderConstants.TemplateID))
            {
                throw new ArgumentException("Item must derive from NewsFolder", nameof(contextItem));
            }
            this.ContextItem = contextItem;
            this._searchServiceRepository = searchServiceRepository;
        }

        public IEnumerable<Item> Get()
        {
            var searchService = this._searchServiceRepository.Get();
            searchService.Settings.Root = this.ContextItem;
            //TODO: Refactor for scalability
            var results = searchService.FindAll();
            return results.Results.Select(x => x.Item).Where(x => x != null).OrderByDescending(i => i[NewsArticleConstants.Fields.NewsDate.ID]);
        }

        public IEnumerable<Item> GetLatestNews(int count)
        {
            //TODO: Refactor for scalability
            return this.Get().Take(count);
        }
    }
}
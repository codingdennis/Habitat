namespace Sitecore.Feature.Person.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.Indexing.Models;
    using Sitecore.Foundation.Indexing.Repositories;
    using Fortis.Foundation.CodeGen.Templates.Feature.Person;

    public class PersonRepository
    {
        public IEnumerable<Item> Get(Item contextItem)
        {
            //TODO: convert to use Fortis search foundation module when it is done.
            var searchServiceRepository = new SearchServiceRepository(new SearchSettingsBase { Templates = new[] { PersonConstants.TemplateID } });
            var searchService = searchServiceRepository.Get();
            searchService.Settings.Root = contextItem;
            return searchService.FindAll().Results.Select(x => x.Item).Where(x => x != null);
        }
    }
}
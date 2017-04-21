using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Fortis.Model;
using Fortis.Providers;
using Fortis.Search;
using Fortis.Mvc.Providers;

namespace Fortis.Foundation
{
    public class FortisConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IItemFactory, ItemFactory>();
            serviceCollection.AddSingleton<IItemSearchFactory, ItemSearchFactory>();
            serviceCollection.AddSingleton<IContextProvider, ContextProvider>();
            serviceCollection.AddSingleton<IModelAssemblyProvider, ModelAssemblyProvider>();
            serviceCollection.AddSingleton<ISpawnProvider, SpawnProvider>();
            serviceCollection.AddSingleton<ITemplateMapProvider, TemplateMapProvider>();
            serviceCollection.AddSingleton<ISearchResultsAdapter, SearchResultsAdapter>();

            // Initialise fortis - this is required for places where we can't use DI
            var serviceProvider = serviceCollection.BuildServiceProvider();

            Global.Initialise(
                serviceProvider.GetRequiredService<ISpawnProvider>(),
                serviceProvider.GetRequiredService<IItemFactory>(),
                serviceProvider.GetRequiredService<IItemSearchFactory>()
            );
        }
    }
}
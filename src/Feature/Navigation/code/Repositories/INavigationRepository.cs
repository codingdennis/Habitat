namespace Sitecore.Feature.Navigation.Repositories
{
    using Sitecore.Data.Items;
    using Sitecore.Feature.Navigation.Models;
    using Fortis.Foundation.CodeGen.Templates.Feature.Navigation;
    using Fortis.Model;

    public interface INavigationRepository
    {
        IItemFactory ItemFactory { get; }
        INavigationRoot GetNavigationRoot();
        NavigationItems GetBreadcrumb();
        NavigationItems GetPrimaryMenu();
        NavigationItem GetSecondaryMenuItem();
        NavigationItems GetLinkMenuItems(INavigationRoot menuItem);
    }
}
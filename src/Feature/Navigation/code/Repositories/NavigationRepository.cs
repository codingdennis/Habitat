namespace Sitecore.Feature.Navigation.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Sitecore.Data.Items;
    using Sitecore.Feature.Navigation.Models;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Fortis.Foundation.CodeGen.Templates.Feature.Navigation;
    using Fortis.Foundation.CustomWrappers;
    using Fortis.Model;

    public class NavigationRepository : INavigationRepository
    {
        public IItemFactory ItemFactory { get; }
        private readonly INavigationRoot _navigationRoot;
        private ICustomItemWrapper _contextItem;

        public NavigationRepository(Item contextItem, IItemFactory itemFactory)
        {
            this.ItemFactory = itemFactory;
            this._contextItem = itemFactory.GetContextItem<ICustomItemWrapper>();

            this._navigationRoot = this.GetNavigationRoot();
            if (this._navigationRoot == null)
            {
                throw new InvalidOperationException($"Cannot determine navigation root from '{((Item)this._contextItem.Original).Paths.FullPath}'");
            }
        }

        public INavigationRoot GetNavigationRoot()
        {
            var navRoot = this._contextItem?.AncestorOrSelf<INavigationRoot>() ?? this.ItemFactory.GetSiteHome<IItemWrapper>().AncestorOrSelf<INavigationRoot>();
            return navRoot;
        }

        public NavigationItems GetBreadcrumb()
        {
            var items = new NavigationItems
                        {
                            Items = this.GetNavigationHierarchy(true).Reverse().ToList()
                        };

            for (var i = 0; i < items.Items.Count - 1; i++)
            {
                items.Items[i].Level = i;
                items.Items[i].IsActive = i == items.Items.Count - 1;
            }

            return items;
        }

        public NavigationItems GetPrimaryMenu()
        {
            var navItems = this.GetChildNavigationItems(this._navigationRoot, 0, 1);

            this.AddRootToPrimaryMenu(navItems);
            return navItems;
        }

        private void AddRootToPrimaryMenu(NavigationItems navItems)
        {
            if (!this.IncludeInNavigation(this._navigationRoot))
            {
                return;
            }

            var navigationItem = this.CreateNavigationItem(this._navigationRoot, 0, 0);
            //Root navigation item is only active when we are actually on the root item
            navigationItem.IsActive = this._contextItem.ItemID == this._navigationRoot.ItemID;
            navItems?.Items?.Insert(0, navigationItem);
        }

        private bool IncludeInNavigation(IItemWrapper item, bool forceShowInMenu = false)
        {
            var navigableItem = item as INavigable;
            return (navigableItem == null? false : navigableItem.HasContextLanguage() && (forceShowInMenu || navigableItem.ShowInNavigationValue));
        }

        public NavigationItem GetSecondaryMenuItem()
        {
            var rootItem = this.GetSecondaryMenuRoot();
            return rootItem == null ? null : this.CreateNavigationItem(rootItem, 0, 3);
        }

        public NavigationItems GetLinkMenuItems(INavigationRoot menuRoot)
        {
            if (menuRoot == null)
            {
                throw new ArgumentNullException(nameof(menuRoot));
            }
            return this.GetChildNavigationItems(menuRoot, 0, 0);
        }

        private ICustomItemWrapper GetSecondaryMenuRoot()
        {
            return this.FindActivePrimaryMenuItem();
        }

        private ICustomItemWrapper FindActivePrimaryMenuItem()
        {
            var primaryMenuItems = this.GetPrimaryMenu();
            //Find the active primary menu item
            var activePrimaryMenuItem = primaryMenuItems.Items.FirstOrDefault(i => i.Item.ItemID != this._navigationRoot.ItemID && i.IsActive);
            return activePrimaryMenuItem?.Item;
        }

        private IEnumerable<NavigationItem> GetNavigationHierarchy(bool forceShowInMenu = false)
        {
            var item = this._contextItem as IItemWrapper;
            var siteRoot = this.ItemFactory.GetSiteRoot<IItemWrapper>();
            while (item.ItemID != siteRoot.ItemID)
            {
                if (this.IncludeInNavigation(item, forceShowInMenu))
                {
                    yield return this.CreateNavigationItem(item as ICustomItemWrapper, 0);
                }

                item = item.Parent<IItemWrapper>();
            }
        }

        private NavigationItem CreateNavigationItem(ICustomItemWrapper item, int level, int maxLevel = -1)
        {
            var targetItem = item.IsDerived(LinkMenuItemConstants.TemplateID) ? ((ILinkMenuItem)item).Link.GetTarget<INavigable>() : item;
            return new NavigationItem
                   {
                       Item = item,
                       Url = item.IsDerived(LinkConstants.TemplateID) ? ((ILink)item).Link.Url : item.GenerateUrl(),
                       Target = item.IsDerived(LinkConstants.TemplateID) ? ((ILink)item).Link.Target : "",
                       IsActive = this.IsItemActive(targetItem ?? item),
                       Children = this.GetChildNavigationItems(item, level + 1, maxLevel),
                       ShowChildren = !item.IsDerived(NavigableConstants.TemplateID) || ((INavigable)item).ShowChildrenValue
                   };
        }

        private NavigationItems GetChildNavigationItems(ICustomItemWrapper parentItem, int level, int maxLevel)
        {
            if (level > maxLevel || !parentItem.HasChildren)
            {
                return null;
            }
            var childItems = parentItem.Children<INavigable>().Where(item => this.IncludeInNavigation(item)).Select(i => this.CreateNavigationItem(i, level, maxLevel));
            return new NavigationItems
                   {
                       Items = childItems.ToList()
                   };
        }

        private bool IsItemActive(ICustomItemWrapper item)
        {
            return this._contextItem.ItemID == item.ItemID || (this._contextItem.Original as Item).Axes.GetAncestors().Any(a => a.ID.Guid == item.ItemID);
        }
    }
}
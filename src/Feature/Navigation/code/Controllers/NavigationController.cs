namespace Sitecore.Feature.Navigation.Controllers
{
    using System.Web.Mvc;
    using Sitecore.Feature.Navigation.Repositories;
    using Sitecore.Foundation.Alerts.Extensions;
    using Sitecore.Foundation.Alerts.Models;
    using Sitecore.Foundation.Dictionary.Repositories;
    using Fortis.Foundation.CodeGen.Templates.Project.Common.ContentTypes;
    using Fortis.Model;
    using IItemFactory = Fortis.Model.IItemFactory;

    public class NavigationController : Controller
    {
        private readonly INavigationRepository _navigationRepository;
        private readonly IItemFactory _itemFactory;

        public NavigationController() : this(new NavigationRepository(Mvc.Presentation.RenderingContext.Current.ContextItem, DependencyResolver.Current.GetService<IItemFactory>()))
        {
        }

        public NavigationController(INavigationRepository navigationRepository)
        {
            this._navigationRepository = navigationRepository;
            this._itemFactory = navigationRepository.ItemFactory;
        }

        public ActionResult Breadcrumb()
        {
            var items = this._navigationRepository.GetBreadcrumb();
            return this.View("Breadcrumb", items);
        }

        public ActionResult PrimaryMenu()
        {
            var items = this._navigationRepository.GetPrimaryMenu();
            return this.View("PrimaryMenu", items);
        }

        public ActionResult SecondaryMenu()
        {
            var item = this._navigationRepository.GetSecondaryMenuItem();
            return this.View("SecondaryMenu", item);
        }

        public ActionResult NavigationLinks()
        {
            if (string.IsNullOrEmpty(Mvc.Presentation.RenderingContext.Current.Rendering.DataSource))
            {
                return null;
            }
            var renderingModel = this._itemFactory.GetRenderingContextItems<IItemWrapper, ILinkMenu>();
            var items = this._navigationRepository.GetLinkMenuItems(renderingModel.RenderingItem);
            return this.View(items);
        }

        public ActionResult LinkMenu()
        {
            if (string.IsNullOrEmpty(Mvc.Presentation.RenderingContext.Current.Rendering.DataSource))
            {
                return Context.PageMode.IsExperienceEditor ? this.InfoMessage(new InfoMessage(DictionaryPhraseRepository.Current.Get("/Navigation/Link Menu/No Items", "This menu has no items."), InfoMessage.MessageType.Warning)) : null;
            }
            var renderingModel = this._itemFactory.GetRenderingContextItems<IItemWrapper, ILinkMenu>();
            var items = this._navigationRepository.GetLinkMenuItems(renderingModel.RenderingItem);
            return this.View("LinkMenu", items);
        }
    }
}
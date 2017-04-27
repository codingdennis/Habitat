namespace Sitecore.Foundation.Assets.Pipelines.GetPageRendering
{
    using System.Linq;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.Mvc.Pipelines.Response.GetPageRendering;
    using Sitecore.Mvc.Presentation;
    using Fortis.Foundation.CodeGen.Templates.Foundation.Assets;

    public class AddThemeAssets : AddRenderingAssets
    {
        public override void Process(GetPageRenderingArgs args)
        {
            this.AddAssets();
        }

        private void AddAssets()
        {
            var themeItem = this.GetThemeItem(PageContext.Current.Item);
            if (themeItem == null || !themeItem.IsDerived(RenderingAssetsConstants.TemplateID))
                return;

            AddAssetsFromItem(themeItem);
        }

        private Item GetThemeItem(Item item)
        {
            var hasThemeItems = item.GetAncestorsAndSelfOfTemplate(HasThemeConstants.TemplateID);
            var ancestorItem = hasThemeItems.Select(i => i.TargetItem(HasThemeConstants.Fields.Theme.ID)).FirstOrDefault(i => i != null && i.IsDerived(RenderingAssetsConstants.TemplateID));
            if (ancestorItem != null)
                return ancestorItem;
            var hasThemeItem = Context.Site.GetContextItem(HasThemeConstants.TemplateID);
            return hasThemeItem?.TargetItem(HasThemeConstants.Fields.Theme.ID);
        }
    }
}
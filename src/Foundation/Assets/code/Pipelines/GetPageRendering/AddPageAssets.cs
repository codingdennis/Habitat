namespace Sitecore.Foundation.Assets.Pipelines.GetPageRendering
{
    using System.Linq;
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.Assets.Models;
    using Sitecore.Foundation.Assets.Repositories;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.Mvc.Pipelines.Response.GetPageRendering;
    using Sitecore.Mvc.Presentation;
    using Fortis.Foundation.CodeGen.Templates.Foundation.Assets;

    public class AddPageAssets : GetPageRenderingProcessor
    {
        public override void Process(GetPageRenderingArgs args)
        {
            this.AddAssets(PageContext.Current.Item);
        }

        protected void AddAssets(Item item)
        {
            var styling = this.GetPageAssetValue(item, PageAssetsConstants.Fields.CssCode.ID);
            if (!string.IsNullOrWhiteSpace(styling))
            {
                AssetRepository.Current.AddInlineStyling(styling, true);
            }
            var scriptBottom = this.GetPageAssetValue(item, PageAssetsConstants.Fields.JavascriptCodeBottom.ID);
            if (!string.IsNullOrWhiteSpace(scriptBottom))
            {
                AssetRepository.Current.AddInlineScript(scriptBottom, ScriptLocation.Body, true);
            }
            var scriptHead = this.GetPageAssetValue(item, PageAssetsConstants.Fields.JavascriptCodeTop.ID);
            if (!string.IsNullOrWhiteSpace(scriptHead))
            {
                AssetRepository.Current.AddInlineScript(scriptHead, ScriptLocation.Head, true);
            }
        }

        private string GetPageAssetValue(Item item, ID assetField)
        {
            if (item.IsDerived(PageAssetsConstants.TemplateID))
            {
                var assetValue = item[assetField];
                if (!string.IsNullOrWhiteSpace(assetValue))
                {
                    return assetValue;
                }
            }

            return GetInheritedPageAssetValue(item, assetField);
        }

        private static string GetInheritedPageAssetValue(Item item, ID assetField)
        {
            var inheritedAssetItem = item.Axes.GetAncestors().FirstOrDefault(i => i.IsDerived(PageAssetsConstants.TemplateID) && MainUtil.GetBool(item[PageAssetsConstants.Fields.InheritAssets.ID], false) && string.IsNullOrWhiteSpace(item[assetField]));
            return inheritedAssetItem?[assetField];
        }
    }
}
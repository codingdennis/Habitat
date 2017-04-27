namespace Sitecore.Foundation.Assets.Pipelines.GetPageRendering
{
    using System.Collections.Generic;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.Foundation.Assets.Models;
    using Sitecore.Foundation.Assets.Repositories;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.Mvc.Pipelines.Response.GetPageRendering;
    using Sitecore.Mvc.Presentation;
    using Fortis.Foundation.CodeGen.Templates.Foundation.Assets;

    public class AddRenderingAssets : GetPageRenderingProcessor
    {
        public override void Process(GetPageRenderingArgs args)
        {
            this.AddAssets(args.PageContext.PageDefinition.Renderings);
        }

        private void AddAssets(IEnumerable<Rendering> renderings)
        {
            foreach (var rendering in renderings)
            {
                var renderingItem = this.GetRenderingItem(rendering);
                if (renderingItem == null)
                {
                    return;
                }

                AddAssetsFromItem(renderingItem);
            }
        }

        protected static void AddAssetsFromItem(Item renderingItem)
        {
            if (!renderingItem.IsDerived(RenderingAssetsConstants.TemplateID))
                return;
            AddScriptAssetsFromRendering(renderingItem);
            AddInlineScriptFromRendering(renderingItem);
            AddStylingAssetsFromRendering(renderingItem);
            AddInlineStylingFromAssets(renderingItem);
        }

        private static void AddInlineStylingFromAssets(Item renderingItem)
        {
            var cssInline = renderingItem[RenderingAssetsConstants.Fields.CssInline.ID];
            if (string.IsNullOrEmpty(cssInline))
            {
                return;
            }
            var asset = AssetRepository.Current.AddInlineStyling(cssInline, true);
            asset.AddOnceToken = renderingItem.ID.ToString();
        }

        private static void AddStylingAssetsFromRendering(Item renderingItem)
        {
            var cssAssets = renderingItem[RenderingAssetsConstants.Fields.CssAssets.ID];
            foreach (var cssAsset in cssAssets.Split(';', ',', '\n'))
            {
                AssetRepository.Current.AddStylingFile(cssAsset, true);
            }
        }

        private static void AddInlineScriptFromRendering(Item renderingItem)
        {
            var javaScriptInline = renderingItem[RenderingAssetsConstants.Fields.JavaScriptInline.ID];
            if (!string.IsNullOrEmpty(javaScriptInline))
            {
                var asset = AssetRepository.Current.AddInlineScript(javaScriptInline, ScriptLocation.Body, true);
                asset.AddOnceToken = renderingItem.ID.ToString();
            }
        }

        private static void AddScriptAssetsFromRendering(Item renderingItem)
        {
            var javaScriptAssets = renderingItem[RenderingAssetsConstants.Fields.JavaScriptAssets.ID];
            foreach (var javaScriptAsset in javaScriptAssets.Split(';', ',', '\n'))
            {
                AssetRepository.Current.AddScriptFile(javaScriptAsset, true);
            }
        }

        private Item GetRenderingItem(Rendering rendering)
        {
            if (rendering.RenderingItem == null)
            {
                Log.Warn($"rendering.RenderingItem is null for {rendering.RenderingItemPath}", this);
                return null;
            }

            if (Context.PageMode.IsNormal && rendering.Caching.Cacheable)
            {
                AssetRepository.Current.Add(rendering.RenderingItem.ID);
            }
            return rendering.RenderingItem.InnerItem;
        }
    }
}
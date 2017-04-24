namespace Sitecore.Feature.Teasers.Models
{
    using System;
    using Sitecore.Data.Fields;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Fortis.Foundation.CodeGen.Templates.Feature.Teasers;

    public class DynamicTeaserItem
    {
        public DynamicTeaserItem(Item headline) : this()
        {
            this.Item = headline;
            this.Title = headline[HeadlineConstants.Fields.TeaserTitle.ID];
            this.Icon = this.GetIcon(headline);
        }

        private string GetIcon(Item headline)
        {
            return headline?.TargetItem(HeadlineConstants.Fields.TeaserIcon.ID)?[IconConstants.Fields.CssClass.ID];
        }

        public DynamicTeaserItem()
        {
            this.HeaderId = $"header{Guid.NewGuid().ToString("N")}";
            this.PanelId = $"panel{Guid.NewGuid().ToString("N")}";
        }

        [CanBeNull]
        public Item Item { get; set; }

        [CanBeNull]
        public string Title { get; private set; }

        [CanBeNull]
        public string Icon { get; set; }

        public bool IsActive { get; set; }
        public string HeaderId { get; private set; }
        public string PanelId { get; private set; }
    }
}
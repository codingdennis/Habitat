using System;
using System.Collections.Generic;
using Fortis.Model;
using Fortis.Providers;
using Sitecore.Data.Items;
using Sitecore.Data;
using System.Linq;

namespace Fortis.Foundation.CustomWrappers
{
    public class CustomItemWrapper : ItemWrapper, ICustomItemWrapper, IFortisItem
    {
        public CustomItemWrapper(ISpawnProvider spawnProvider) : base(spawnProvider)
        {
        }

        public CustomItemWrapper(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
        }

        public CustomItemWrapper(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
        {
        }

        public CustomItemWrapper(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider)
        {
        }

        public string TemplateName
        {
            get
            {
                var original = GetItem();
                return original != null ? original.TemplateName : string.Empty;
            }
        }

        public DateTime CreatedDate
        {
            get
            {
                var original = GetItem();
                return original != null ? original.Statistics.Created : DateTime.Today;
            }
        }

        public bool IsHidden
        {
            get
            {
                var original = GetItem();
                return original != null && original.Appearance.Hidden;
            }
        }

        public int SortOrder
        {
            get
            {
                var original = GetItem();
                return original != null ? original.Appearance.Sortorder : 100;
            }
        }

        public DateTime UpdatedDate
        {
            get
            {
                var original = GetItem();
                return original != null ? original.Statistics.Updated : DateTime.Today;
            }
        }

        public bool IsDerived(ID templateId) => (this.TemplateId == templateId.Guid || this.TemplateIds.Any(o => o == templateId.Guid));

        public bool HasContextLanguage() => (GetItem().Versions.GetLatestVersion()?.Versions.Count > 0);

        public bool HasLayout() => (GetItem()?.Visualization?.Layout != null);

        private Item GetItem() => (Original as Item);
    }
}
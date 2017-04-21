namespace Sitecore.Feature.Accounts.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Sitecore.Configuration;
    using Sitecore.Data;
    using Sitecore.Data.Fields;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.SecurityModel;
    using Fortis.Foundation.CodeGen.Templates.Feature.Accounts;

    public class ProfileSettingsService : IProfileSettingsService
    {
        public virtual Item GetUserDefaultProfile()
        {
            using (new SecurityDisabler())
            {
                var item = GetSettingsItem(Context.Item);
                Assert.IsNotNull(item, "Page with profile settings isn't specified");
                var database = Database.GetDatabase(Settings.ProfileItemDatabase);
                var profileField = item.Fields[ProfileSettingsConstants.Fields.UserProfile.ID];
                var targetItem = database.GetItem(profileField.Value);

                return targetItem;
            }
        }

        public virtual IEnumerable<string> GetInterests()
        {
            var item = GetSettingsItem(null);

            return item?.TargetItem(ProfileSettingsConstants.Fields.InterestsFolder.ID)?.Children.Where(i => i.IsDerived(InterestConstants.TemplateID))?.Select(i => i.Fields[InterestConstants.Fields.Title.ID].Value) ?? Enumerable.Empty<string>();
        }

        private static Item GetSettingsItem(Item contextItem)
        {
            Item item = null;

            if (contextItem != null)
            {
                item = contextItem.GetAncestorOrSelfOfTemplate(ProfileSettingsConstants.TemplateID);
            }
            item = item ?? Context.Site.GetContextItem(ProfileSettingsConstants.TemplateID);

            return item;
        }
    }
}
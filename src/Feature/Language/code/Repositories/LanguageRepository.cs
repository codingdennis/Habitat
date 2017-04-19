namespace Sitecore.Feature.Language.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Sitecore.Data.Fields;
    using Sitecore.Feature.Language.Models;
    using Sitecore.Foundation.Multisite;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Fortis.Foundation.CodeGen.Templates.Feature.Language;

    public static class LanguageRepository
    {
        private static IEnumerable<Language> GetAll()
        {
            var languages = Context.Database.GetLanguages();
            return languages.Select(LanguageFactory.Create);
        }

        public static Language GetActive()
        {
            return LanguageFactory.Create(Context.Language);
        }

        public static IEnumerable<Language> GetSupportedLanguages()
        {
            var languages = GetAll();
            var siteContext = new SiteContext();
            var siteDefinition = siteContext.GetSiteDefinition(Context.Item);

            if (siteDefinition?.Item == null || !siteDefinition.Item.IsDerived(LanguageSettingsItemConstants.TemplateID))
            {
                return languages;
            }

            var supportedLanguagesField = new MultilistField(siteDefinition.Item.Fields[LanguageSettingsItemConstants.Fields.SupportedLanguages.ID]);
            if (supportedLanguagesField.Count == 0)
            {
                return Enumerable.Empty<Language>();
            }

            var supportedLanguages = supportedLanguagesField.GetItems();

            languages = languages.Where(language => supportedLanguages.Any(item => item.Name.Equals(language.Name)));

            return languages;
        }
    }
}
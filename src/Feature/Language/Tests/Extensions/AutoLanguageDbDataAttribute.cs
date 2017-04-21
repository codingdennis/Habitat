namespace Sitecore.Feature.Language.Tests.Extensions
{
    using Ploeh.AutoFixture;
    using Sitecore.FakeDb;
    using Sitecore.Foundation.Multisite;
    using Sitecore.Foundation.Testing.Attributes;
    using Fortis.Foundation.CodeGen.Templates.Feature.Language;

    public class AutoLanguageDbDataAttribute : AutoDbDataAttribute
    {
        public AutoLanguageDbDataAttribute()
        {
            var db = this.Fixture.Create<Db>();
            db.Add(new DbTemplate(Templates.Site.ID));
            db.Add(new DbTemplate(LanguageSettingsConstants.TemplateID)
            {
                Fields =
                {
                    {
                        LanguageSettingsConstants.Fields.SupportedLanguages.ID, string.Empty
                    }
                }
            });
        }
    }
}
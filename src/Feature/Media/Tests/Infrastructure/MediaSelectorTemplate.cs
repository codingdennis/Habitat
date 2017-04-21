namespace Sitecore.Feature.Media.Tests.Infrastructure
{
    using Sitecore.FakeDb;
    using Fortis.Foundation.CodeGen.Templates.Feature.Media;

    public class MediaSelectorTemplate : DbTemplate
    {
        public MediaSelectorTemplate() : base(HasMediaSelectorItemConstants.TemplateID)
        {
            base.Add(HasMediaSelectorItemConstants.Fields.MediaSelector.ID);
        }
    }
}
namespace Sitecore.Feature.Media.Tests.Infrastructure
{
    using Sitecore.FakeDb;
    using Fortis.Foundation.CodeGen.Templates.Feature.Media;

    public class VideoTemplate : DbTemplate
    {
        public VideoTemplate() : base(HasMediaVideoConstants.TemplateID)
        {
            base.Add(HasMediaVideoConstants.Fields.MediaVideoLink.ID);
        }
    }
}
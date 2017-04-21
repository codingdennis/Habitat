namespace Sitecore.Feature.Media.Tests.Infrastructure
{
    using Sitecore.FakeDb;
    using Fortis.Foundation.CodeGen.Templates.Feature.Media;

    public class VideoTemplate : DbTemplate
    {
        public VideoTemplate() : base(HasMediaVideoItemConstants.TemplateID)
        {
            base.Add(HasMediaVideoItemConstants.Fields.MediaVideoLink.ID);
        }
    }
}
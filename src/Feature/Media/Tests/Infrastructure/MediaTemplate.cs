namespace Sitecore.Feature.Media.Tests.Infrastructure
{
    using Sitecore.FakeDb;
    using Fortis.Foundation.CodeGen.Templates.Feature.Media;

    public class MediaTemplate : DbTemplate
    {
        public MediaTemplate() : base(HasMediaItemConstants.TemplateID)
        {
            base.Add(HasMediaItemConstants.Fields.MediaThumbnail.ID);
            base.BaseIDs = new[]
            {
                HasMediaVideoItemConstants.TemplateID
            };
        }
    }
}
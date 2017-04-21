namespace Sitecore.Feature.Media.Tests.Infrastructure
{
    using Sitecore.FakeDb;
    using Fortis.Foundation.CodeGen.Templates.Feature.Media;

    public class MediaTemplate : DbTemplate
    {
        public MediaTemplate() : base(HasMediaConstants.TemplateID)
        {
            base.Add(HasMediaConstants.Fields.MediaThumbnail.ID);
            base.BaseIDs = new[]
            {
                HasMediaVideoConstants.TemplateID
            };
        }
    }
}
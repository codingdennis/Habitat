namespace Sitecore.Feature.Demo.Tests
{
    using Sitecore.Data;
    using Sitecore.FakeDb;
    using Fortis.Foundation.CodeGen.Templates.Feature.Demo;

    public class DemoContentItem : DbItem
    {
        public DemoContentItem(string name, ID id)
            : base(name, id, DemoContentItemConstants.TemplateID)
        {
        }
    }
}
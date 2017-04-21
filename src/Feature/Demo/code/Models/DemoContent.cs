namespace Sitecore.Feature.Demo.Models
{
    using System.Linq;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.Text;
    using static Configuration.Factory;
    using Fortis.Foundation.CodeGen.Templates.Feature.Demo;

    public class DemoContent
    {
        public Item Item { get; set; }

        public DemoContent(Item item)
        {
            this.Item = item;
        }

        public string HtmlContent
        {
            get
            {
                var content = this.Item[DemoContentConstants.Fields.HTMLContent.ID];
                return this.ReplaceTokens(content);
            }
        }

        private string ReplaceTokens(string content)
        {
            var replacer = GetMasterVariablesReplacer();
            using (new ReplacerContextSwitcher(this.GetReplacementTokens()))
                return replacer.Replace(content, this.Item);
        }

        private string[] GetReplacementTokens()
        {
            return this.Item.Children.Where(i => i.IsDerived(TokenConstants.TemplateID)).SelectMany(i => new[] {$"${i.Name}", i[TextTokenConstants.Fields.TokenValue.ID]}).ToArray();
        }
    }
}
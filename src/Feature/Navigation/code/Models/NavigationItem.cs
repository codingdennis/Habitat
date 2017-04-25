namespace Sitecore.Feature.Navigation.Models
{
    using Sitecore.Data.Items;
    using Fortis.Foundation.CodeGen.Templates.Feature.Navigation;
    using Fortis.Foundation.CustomWrappers;

    public class NavigationItem
    {
        public ICustomItemWrapper Item { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public NavigationItems Children { get; set; }
        public string Target { get; set; }
        public bool ShowChildren { get; set; }
    }
}
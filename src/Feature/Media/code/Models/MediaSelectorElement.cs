namespace Sitecore.Feature.Media.Models
{
    using Fortis.Foundation.CustomWrappers;

    public class MediaSelectorElement
    {
        public ICustomItemWrapper Item { get; set; }
        public string Active { get; set; }
    }
}
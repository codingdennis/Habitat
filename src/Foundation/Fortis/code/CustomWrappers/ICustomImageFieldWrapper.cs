using Fortis.Model.Fields;
using Sitecore.Resources.Media;

namespace Fortis.Foundation.CustomWrappers
{
    public interface ICustomImageFieldWrapper : IImageFieldWrapper, IFortisItem
    {
        int Width { get; }
        int Height { get; }
        string GetSourceUri(MediaUrlOptions options);
    }
}
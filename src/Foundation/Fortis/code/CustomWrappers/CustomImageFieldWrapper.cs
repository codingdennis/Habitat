using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;
using Sitecore;
using Sitecore.Data.Fields;
using Sitecore.Resources.Media;

namespace Fortis.Foundation.CustomWrappers
{
    public class CustomImageFieldWrapper : ImageFieldWrapper, ICustomImageFieldWrapper
    {
        public int Width
        {
            get
            {
                int width = 0;
                int.TryParse(this.ImageField.Width, out width);
                return width;
            }
        }

        public int Height
        {
            get
            {
                int height = 0;
                int.TryParse(this.ImageField.Height, out height);
                return height;
            }
        }

        public CustomImageFieldWrapper(Field field, ISpawnProvider spawnProvider)
            : base(field, spawnProvider)
        {
        }

        public CustomImageFieldWrapper(string key, ref ItemWrapper item, ISpawnProvider spawnProvider, string value = null)
            : base(key, ref item, spawnProvider, value)
        {
        }

        public string GetSourceUri(MediaUrlOptions options)
        {
            if (string.IsNullOrWhiteSpace(this.ImageField.Value))
            {
                return string.Empty;
            }

            var mediaItem = this.ImageField.MediaItem;
            if (mediaItem == null)
            {
                return string.Empty;
            }

            var url = MediaManager.GetMediaUrl(mediaItem, options);
            var cleanUrl = StringUtil.EnsurePrefix('/', url);
            var hashedUrl = HashingUtils.ProtectAssetUrl(cleanUrl);

            return hashedUrl;
        }
    }
}
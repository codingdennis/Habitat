using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fortis.Model.Fields;
using Fortis.Model;
using Fortis.Providers;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Fortis.Foundation.CustomWrappers
{
    public class CustomGeneralLinkFieldWrapper : GeneralLinkFieldWrapper, ICustomGeneralLinkFieldWrapper
    {
        public CustomGeneralLinkFieldWrapper(Field field, ISpawnProvider spawnProvider) : base(field, spawnProvider)
        {
        }

        public CustomGeneralLinkFieldWrapper(string key, ref ItemWrapper item, ISpawnProvider spawnProvider, string value = null) : base(key, ref item, spawnProvider, value)
        {
        }

        public bool IsExternal => base.LinkField.LinkType == "external";

        public string MediaMimeType
        {
            get
            {
                if (this.IsMediaLink)
                {
                    var mediaItem = this.LinkField.TargetItem == null ? (MediaItem)this.LinkField.TargetItem : null;
                    if (mediaItem != null)
                    {
                        return mediaItem.MimeType;
                    }
                }
                return "";
            }
        }
    }
}
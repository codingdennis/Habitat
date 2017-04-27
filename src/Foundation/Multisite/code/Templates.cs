namespace Sitecore.Foundation.Multisite
{
    using Sitecore.Data;
    using Sitecore.Shell.Framework.Commands.Masters;

    public class Templates
    {
        public struct RenderingOptions
        {
            // Rendering Options is an existing Sitecore system template not controlled by Unicorn
            // so its ID and fields need to be manually defined here
            public static ID ID = new ID("{D1592226-3898-4CE2-B190-090FD5F84A4C}");

            public struct Fields
            {
                public static readonly ID DatasourceLocation = new ID("{B5B27AF1-25EF-405C-87CE-369B3A004016}");
                public static readonly ID DatasourceTemplate = new ID("{1A7C85E5-DC0B-490D-9187-BB1DBCB4C72F}");
            }
        }
    }
}
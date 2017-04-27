using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.LocalDatasource
{
    using Sitecore.Data;

    public class Templates
    {
        public struct RenderingOptions
        {
            public static ID ID = new ID("{D1592226-3898-4CE2-B190-090FD5F84A4C}");

            public struct Fields
            {
                // Note that the SupportsLocalDataSource field is an additional field of the existing
                // template: /sitecore/templates/System/Layout/Sections/Rendering Options.
                // As the original template is not controlled by Unicorn the T4 code generation will
                // not be able to detect this and thus this field needs to be manually defined here.
                public static readonly ID SupportsLocalDatasource = new ID("{1C307764-806C-42F0-B7CE-FC173AC8372B}");
            }
        }

        public struct Index
        {
            public struct Fields
            {
                public static readonly string LocalDatasourceContent_IndexFieldName = "local_datasource_content";
            }
        }
    }
}
namespace Sitecore.Feature.FAQ.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Fortis.Foundation.CodeGen.Templates.Feature.FAQ;

    public static class FaqRepository
    {
        public static IEnumerable<IFAQ> Get([NotNull] IFAQGroup item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            return item.GroupMember.GetItems<IFAQ>();
        }
    }
}
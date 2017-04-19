namespace Sitecore.Feature.Identity.Repositories
{
    using System;
    using Sitecore.Data.Items;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Fortis.Foundation.CodeGen.Templates.Feature.Identity;
    using Fortis.Model;

    public static class IdentityRepository
    {
        public static IIdentity Get([NotNull] IItemWrapper contextItem)
        {
            if (contextItem == null)
                throw new ArgumentNullException(nameof(contextItem));

            return contextItem.AncestorOrSelf<IIdentity>() ?? null;
        }
    }
}
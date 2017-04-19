using System;
using Fortis.Model;
using Sitecore.Data;

namespace Fortis.Foundation.CustomWrappers
{
    public interface ICustomItemWrapper : IItemWrapper, IFortisItem
    {
        string TemplateName { get; }
        int SortOrder { get; }
        DateTime CreatedDate { get; }
        DateTime UpdatedDate { get; }
        bool IsHidden { get; }
        bool IsDerived(ID templateId);
        bool HasContextLanguage();
    }
}
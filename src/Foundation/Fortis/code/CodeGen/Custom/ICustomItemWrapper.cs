using System;
using Fortis.Model;

namespace Fortis.Foundation.CodeGen.Custom
{
    public interface ICustomItemWrapper : IItemWrapper, IFortisItem
    {
        string TemplateName { get; }
        int SortOrder { get; }
        DateTime CreatedDate { get; }
        DateTime UpdatedDate { get; }
        bool IsHidden { get; }
    }
}
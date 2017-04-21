using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fortis.Model.Fields;

namespace Fortis.Foundation.CustomWrappers
{
    public interface ICustomGeneralLinkFieldWrapper : IGeneralLinkFieldWrapper
    {
        bool IsExternal { get; }
        string MediaMimeType { get; }
    }
}

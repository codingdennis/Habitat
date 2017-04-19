using System.Collections.Generic;
using Fortis.Model;
using Fortis.Providers;

namespace Fortis.Foundation.CustomWrappers
{
    public class CustomRenderingParameterWrapper : RenderingParameterWrapper, IFortisItem
    {
        public CustomRenderingParameterWrapper(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }
    }
}
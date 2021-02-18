#nullable enable

using Microsoft.AspNetCore.Components;

namespace Ynferno.Shared.Components.Atoms
{
    public abstract class Styleable : ComponentBase
    {
        [Parameter]
        public string CssClass { get; set; } = "";
    }
}

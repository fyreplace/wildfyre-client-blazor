using Microsoft.AspNetCore.Components;

namespace Ynferno.Shared.Components
{
    public abstract class NavigationBase : ComponentBase
    {
        [Parameter]
        public Destination[] Destinations { get; set; }

        public string ItemSize => (100 / Destinations.Length) + "%";
    }

    public struct Destination
    {
        public string Route { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
    }
}

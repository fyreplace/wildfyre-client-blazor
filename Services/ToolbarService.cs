#nullable disable

using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Ynferno.Services
{
    using Fragments = List<RenderFragment>;

    public class ToolbarService : IToolbarService
    {
        public event IToolbarService.ChangedEventHandler Changed;

        public void SetItems(Fragments start = null, Fragments end = null)
        {
            var empty = new Fragments();
            Changed?.Invoke(this, start ?? empty, end ?? empty);
        }
    }
}

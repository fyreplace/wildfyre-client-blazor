#nullable disable

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Ynferno.Services
{
    using Fragments = IEnumerable<RenderFragment>;

    public class ToolbarService : IToolbarService
    {
        public event IToolbarService.ChangedEventHandler Changed;

        public void SetItems(IEnumerable<Fragments> itemsLists)
        {
            var empty = Array.Empty<Fragments>();
            Changed?.Invoke(this, itemsLists ?? empty);
        }
    }
}

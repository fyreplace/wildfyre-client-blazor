#nullable enable

using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Ynferno.Services
{
    using Fragments = List<RenderFragment>;

    public interface IToolbarService
    {
        delegate void ChangedEventHandler(object sender, Fragments start, Fragments end);
        event ChangedEventHandler Changed;

        void SetItems(Fragments? start = null, Fragments? end = null);
    }
}

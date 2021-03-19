#nullable enable

using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Ynferno.Services
{
    using Fragments = IEnumerable<RenderFragment>;

    public interface IToolbarService
    {
        delegate void ChangedEventHandler(object sender, IEnumerable<Fragments> itemsLists);
        event ChangedEventHandler Changed;

        void SetItems(IEnumerable<Fragments>? itemsLists);
    }
}

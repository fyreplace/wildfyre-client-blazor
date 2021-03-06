#nullable enable

using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Ynferno.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IJSRuntime? javascript;

        public HistoryService(IJSRuntime javascript) => this.javascript = javascript;

        public ValueTask Forward() =>
            javascript?.InvokeVoidAsync("window.history.forward") ?? ValueTask.CompletedTask;

        public ValueTask Back() =>
            javascript?.InvokeVoidAsync("window.history.back") ?? ValueTask.CompletedTask;

        public ValueTask Replace(string uri)
        {
            var state = new object();
            return javascript?.InvokeVoidAsync("window.history.replaceState", state, "", uri)
                ?? ValueTask.CompletedTask;
        }
    }
}

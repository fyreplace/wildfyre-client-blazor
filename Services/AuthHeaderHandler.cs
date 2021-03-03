#nullable enable

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace Ynferno.Services
{
    public class AuthHeaderHandler : DelegatingHandler
    {
        private readonly ILocalStorageService localStorage;

        public AuthHeaderHandler(ILocalStorageService localStorage) => this.localStorage = localStorage;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = await localStorage.GetItemAsStringAsync("auth.token") ?? "";

            if (token.Length > 0)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Token", token);
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}

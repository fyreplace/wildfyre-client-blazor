using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Ynferno.Services;

namespace Ynferno
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var apiUrl = builder.Configuration["apiUrl"];
            builder.RootComponents.Add<App>("#app");
            builder.Services
                .AddBlazoredLocalStorage()
                .AddBlazoredSessionStorage()
                .AddHistory()
                .AddAuthHeaderHandler()
                .AddToolbar();

            foreach (var refit in new List<IHttpClientBuilder>() {
                builder.Services.AddRefitClient<IAuthService>(),
                builder.Services.AddRefitClient<IAuthorService>(),
            })
            {
                refit
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl))
                    .AddHttpMessageHandler<AuthHeaderHandler>();
            }
            await builder.Build().RunAsync();
        }
    }
}

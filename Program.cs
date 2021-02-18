using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
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
                .AddRefitClient<IAuthService>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl));
            await builder.Build().RunAsync();
        }
    }
}

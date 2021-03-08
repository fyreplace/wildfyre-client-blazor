#nullable enable

using System;
using Microsoft.Extensions.DependencyInjection;
using Ynferno.Services;

namespace Blazored.LocalStorage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHistory(this IServiceCollection services) =>
            services.AddSingleton<IHistoryService, HistoryService>();

        public static IServiceCollection AddAuthHeaderHandler(this IServiceCollection services) =>
            services.AddScoped<AuthHeaderHandler>();

        public static IServiceCollection AddToolbar(this IServiceCollection services) =>
            services.AddSingleton<IToolbarService, ToolbarService>();
    }
}
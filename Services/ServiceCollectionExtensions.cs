#nullable enable

using System;
using Microsoft.Extensions.DependencyInjection;
using Ynferno.Services;

namespace Blazored.LocalStorage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHistory(this IServiceCollection services)
        {
            services.AddScoped<IHistoryService, HistoryService>();
            return services;
        }
    }
}
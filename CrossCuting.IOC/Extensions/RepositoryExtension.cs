using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCuting.IOC.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, string connectionString, string migrationsAssemblyName)
        {
            return services;
        }
    }
}

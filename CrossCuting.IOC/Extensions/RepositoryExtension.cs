using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CrossCuting.IOC.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, string connectionString, string migrationsAssemblyName)
        {
            services.AddDbContext<GymContext>(options =>
            {

                options.UseSqlServer(connectionString, sqlServerOptionsAction => sqlServerOptionsAction.MigrationsAssembly(migrationsAssemblyName));
                //.UseLoggerFactory(new LoggerFactory(new[] { new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider() }))

            });
            return services;
        }
    }
}

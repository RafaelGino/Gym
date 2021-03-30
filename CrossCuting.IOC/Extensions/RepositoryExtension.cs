using Domain.Repositories;
using Infra.Data.Abstractions.Data;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Infra.Data.UnitOfWork;
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
                options.UseSqlServer(connectionString, sqlServerOptionsAction => sqlServerOptionsAction.MigrationsAssembly(migrationsAssemblyName)).EnableSensitiveDataLogging();
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //repositories
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();

            return services;
        }
    }
}

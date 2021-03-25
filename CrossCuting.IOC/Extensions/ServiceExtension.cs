using Application.Implementation;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCuting.IOC.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();

            return services;
        }
    }
}

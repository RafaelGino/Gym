using Microsoft.Extensions.DependencyInjection;

namespace CrossCuting.IOC.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddScoped<IAnexoService, AnexoService>();
            

            return services;
        }
    }
}

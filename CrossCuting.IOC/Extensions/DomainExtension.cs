using Microsoft.Extensions.DependencyInjection;

namespace CrossCuting.IoC.Extensions
{
    public static class DomainExtension
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            //services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            

            return services;
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Notification.API.Data;
using Notification.API.Service;
using Microsoft.EntityFrameworkCore;

namespace Notification.API.Infrastructure.Extentions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NotificationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("NotificationConnectionString")));
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            return services;
        }
    }
}

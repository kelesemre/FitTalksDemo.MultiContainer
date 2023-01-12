using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Notification.API.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Notification.API.Infrastructure.Extentions;

namespace Notification.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build()
              .MigrateDatabase<NotificationDbContext>((context, services) => 
               {
                  var logger = services.GetService<ILogger<NotificationDbContextSeed>>();
                  NotificationDbContextSeed.SeedAsync(context, logger).Wait(); // after Migration, seed the Db
               })
              .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

using Microsoft.Extensions.Logging;
using Notification.API.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.API.Data
{
    public class NotificationDbContextSeed
    {
        public static async Task SeedAsync(NotificationDbContext dbContext, ILogger<NotificationDbContextSeed> logger)
        {
            if (!dbContext.Notifications.Any()) // check any product in the db
            {
                dbContext.Notifications.AddRange(InsertDummyNotifications());
                await dbContext.SaveChangesAsync();
                logger.LogInformation("------Seed database associated with context {DbContextName}------", typeof(NotificationDbContext).Name);
            }
        }


        private static IEnumerable<NotificationCustomer> InsertDummyNotifications()
        {
            return new List<NotificationCustomer>
            {
                new NotificationCustomer(){  Name = "Ali", Surname = "Alioglu", Email = "developer.emrekeles@gmail.com"},
            };
        }
    }
}

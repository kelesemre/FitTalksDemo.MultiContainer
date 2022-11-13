using Microsoft.EntityFrameworkCore;
using Notification.API.Entities;

namespace Notification.API.Data
{
    public class NotificationDbContext : DbContext
    {
        public DbSet<NotificationCustomer> Notifications { get; set; } = default!;

        public NotificationDbContext(DbContextOptions<NotificationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

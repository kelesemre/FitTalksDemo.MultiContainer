using Notification.API.Common;
using Notification.API.Entities;

namespace Notification.API.Data
{
    public class NotificationRepository: EntityRepositoryBase<NotificationCustomer>, INotificationRepository
    {
        public NotificationRepository(NotificationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

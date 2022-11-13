using Notification.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.API.Service
{
    public interface INotificationService
    {
        public Task<List<NotificationCustomer>> GetAllCustomerNotifications();
    }
}

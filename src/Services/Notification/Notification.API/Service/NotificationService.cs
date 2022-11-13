using Microsoft.Extensions.Logging;
using Notification.API.Data;
using Notification.API.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.API.Service
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _customerNotificationRepository;
        private readonly ILogger<NotificationService> _logger;

        public NotificationService(INotificationRepository customerNotificationRepository, ILogger<NotificationService> logger)
        {
            _customerNotificationRepository = customerNotificationRepository;
            _logger = logger;
        }

        public async Task<List<NotificationCustomer>> GetAllCustomerNotifications()
        {
            var responseList = await _customerNotificationRepository.GetAllAsync();
            _logger.LogInformation("{responseList.Count} notifications were fetched...",responseList.Count);
            return responseList.ToList();
        }
    }
}

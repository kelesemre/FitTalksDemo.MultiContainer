using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventBus.Messages;
using MassTransit;
using Microsoft.Extensions.Logging;
using Notification.API.Entities;
using Notification.API.Service;

namespace Notification.API.EventBusConsumer
{
    public class CustomerCreationEventConsumer : IConsumer<CustomerCreationEvent>
    {
        private readonly INotificationService _notificationService;
        private readonly ILogger<CustomerCreationEventConsumer> _logger;

        public CustomerCreationEventConsumer(INotificationService notificationService, ILogger<CustomerCreationEventConsumer> logger)
        {
            _notificationService = notificationService;
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<CustomerCreationEvent> context)
        {
            var eventObject = context.Message;
            var notificationCustomer = new NotificationCustomer { Email = eventObject.Email, Name = eventObject.Name, Surname = eventObject.Surname };
            await _notificationService.SaveCustomerNotificationAsync(notificationCustomer);
        }
    }
}

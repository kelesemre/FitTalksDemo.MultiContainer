using Microsoft.AspNetCore.Mvc;
using Notification.API.Common;
using Notification.API.Entities;
using Notification.API.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerNotificationController : NotificationControllerBase
    {
        private readonly INotificationService _notificationService;

        public CustomerNotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        [Route("[action]", Name = "GetAllCustomerNotificationsAsync")]
        public async Task<IActionResult> GetAllCustomerNotificationsAsync()
        {
            var response = await _notificationService.GetAllCustomerNotificationsAsync();
            return CreateActionResultInstance(GenericResponse<List<NotificationCustomer>>.Success(response));
        }
    }
}

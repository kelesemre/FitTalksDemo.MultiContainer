using Microsoft.AspNetCore.Mvc;

namespace Notification.API.Common
{
    public class NotificationControllerBase
    {
        /// <summary>
        /// Wrap objectResults in the controller class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public IActionResult CreateActionResultInstance<T>(IGenericResponse<T> response)
        {
            return new ObjectResult(response);
        }
    }
}

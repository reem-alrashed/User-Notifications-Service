using Microsoft.AspNetCore.Mvc;
using UserNotificationsService.Models;
using UserNotificationsService.Services;

namespace UserNotificationsService.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly NotificationService _notificationService;

        public NotificationsController()
        {
            _notificationService = new NotificationService(); // Later, use Dependency Injection
        }

        [HttpPost]
        public IActionResult SendNotification([FromBody] NotificationRequest request)
        {
            if (string.IsNullOrEmpty(request.Recipient) || string.IsNullOrEmpty(request.Message))
            {
                return BadRequest("Recipient and Message are required.");
            }

            _notificationService.SendNotification(request);
            return Ok("Notification sent successfully.");
        }
    }
}

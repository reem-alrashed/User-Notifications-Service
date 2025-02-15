using UserNotificationsService.Models;
using System;

namespace UserNotificationsService.Services
{
    public class NotificationService
    {
        public void SendNotification(NotificationRequest request)
        {
            // Mock sending logic (Replace with actual provider integration later)
            Console.WriteLine($"Sending {request.NotificationType} to {request.Recipient}: {request.Message}");
        }
    }
}

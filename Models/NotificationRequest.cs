namespace UserNotificationsService.Models
{
    public class NotificationRequest
    {
        public string Recipient { get; set; } // Email or Phone Number
        public string Message { get; set; }
        public string NotificationType { get; set; } // "email", "sms", "push"
    }
}

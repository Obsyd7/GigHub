using GigHub.Core.Models;
using System.Collections.Generic;

namespace GigHub.Core.Repositories
{
    public interface INotificationRepository
    {
        List<Notification> GetUserNotificationsWithArtist(string userId);
        List<UserNotification> GetUserNotifications(string user);
    }
}
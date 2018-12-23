using FluentAssertions;
using GigHub.Core.Models;
using GigHub.Persistence;
using GigHub.Persistence.Repositories;
using GigHub.Tests.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;

namespace GigHub.Tests.Persistence.Repositories
{
    [TestClass]
    public class NotificationRepositoryTests
    {
        private NotificationRepository _repository;
        private Mock<DbSet<UserNotification>> _mockUserNotification;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockUserNotification = new Mock<DbSet<UserNotification>>();

            var mockContext = new Mock<IApplicationDbContext>();
            mockContext.SetupGet(c => c.UserNotifications).Returns(_mockUserNotification.Object);

            _repository = new NotificationRepository(mockContext.Object);
        }

        [TestMethod]
        public void GetNewNotificationsFor_NotificationIsRead_ShouldNotBeReturned()
        {
            var notification = Notification.GigCanceled(new Gig());
            var user = new ApplicationUser();
            var userNotification = new UserNotification(user, notification);
            userNotification.Read();

            _mockUserNotification.SetSource(new[] { userNotification });

            var result = _repository.GetUserNotifications(user.Id);

            result.Should().BeEmpty();
        }
    }
}

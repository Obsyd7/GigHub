using System.Data.Entity;
using GigHub.Core.Models;
using GigHub.Persistence;
using GigHub.Persistence.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GigHub.Tests.Persistance.Repositories
{
    [TestClass]
    public class GigRepositoriesTests
    {
        private GigRepository _repository;

        [TestInitialize]
        public void TestInitialize()
        {
            var mockGigs = new Mock<DbSet<Gig>>();

            var mockContext = new Mock<IApplicationDbContext>();
            mockContext.SetupGet(c => c.Gigs).Returns(mockGigs.Object);

            _repository = new GigRepository(mockContext.Object);
        }
    }
}

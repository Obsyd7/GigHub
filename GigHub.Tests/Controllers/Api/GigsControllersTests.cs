using GigHub.Controllers.Api;
using GigHub.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Claims;
using System.Security.Principal;

namespace GigHub.Tests.Controllers.Api
{
    [TestClass]
    public class GigsControllersTests
    {
        public GigsControllersTests()
        {
            var identity = new GenericIdentity("user1@domain.com");
            identity.AddClaim(
               new Claim("http://schemas.xml.org/ws/2005/05/identity/claims/name", "user1@domain.com"));
            identity.AddClaim(
                new Claim("http://schemas.xml.org/ws/2005/05/identity/claims/nameidentifier", "1"));

            var principal = new GenericPrincipal(identity, null);

            var mockUoW = new Mock<IUnitOfWork>();

            //var controller = new GigsController(mockUoW.Object);


        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}

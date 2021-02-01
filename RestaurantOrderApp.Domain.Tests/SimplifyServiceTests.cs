using NUnit.Framework;
using RestaurantOrderApp.Domain.Interfaces.Services;

namespace RestaurantOrderApp.Domain.Tests
{
    public class SimplifyServiceTests : BaseTest
    {
        private ISimplifyService _simplifyService;

        [SetUp]
        public void Setup()
        {
            _simplifyService = (ISimplifyService)ServiceProvider.GetService(typeof(ISimplifyService));
        }

        [Test]
        public void Morning123Test()
        {
            #region Arrange
            string input = "morning, 1, 2, 3";
            string outputExpected = "morning,1,2,3";
            #endregion

            #region Act
            var isValid = _simplifyService.Simplify(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }

        [Test]
        public void Night13Test()
        {
            #region Arrange
            string input = "Night, 1, 3";
            string outputExpected = "night,1,3";
            #endregion

            #region Act
            var isValid = _simplifyService.Simplify(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }
    }
}
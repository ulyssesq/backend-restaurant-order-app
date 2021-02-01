using NUnit.Framework;
using RestaurantOrderApp.Domain.Interfaces.Services;

namespace RestaurantOrderApp.Domain.Tests
{
    public class OrderServiceTests : BaseTest
    {
        private IOrderService _orderService;

        [SetUp]
        public void Setup()
        {
            _orderService = (IOrderService)ServiceProvider.GetService(typeof(IOrderService));
        }

        [Test]
        public void Morning123Test()
        {
            #region Arrange
            string input = "morning, 1, 2, 3";
            string outputExpected = "eggs, toast, coffee";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Morning213Test()
        {
            #region Arrange
            string input = "morning, 2, 1, 3";
            string outputExpected = "eggs, toast, coffee";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Morning1234Test()
        {
            #region Arrange
            string input = "morning, 1, 2, 3, 4";
            string outputExpected = "eggs, toast, coffee, error";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Morning12333Test()
        {
            #region Arrange
            string input = "morning, 1, 2, 3, 3, 3";
            string outputExpected = "eggs, toast, coffee(x3)";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Night1234Test()
        {
            #region Arrange
            string input = "night, 1, 2, 3, 4";
            string outputExpected = "steak, potato, wine, cake";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Night1224Test()
        {
            #region Arrange
            string input = "night, 1, 2, 2, 4";
            string outputExpected = "steak, potato(x2), cake";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Night1235Test()
        {
            #region Arrange
            string input = "night, 1, 2, 3, 5";
            string outputExpected = "steak, potato, wine, error";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Night11235Test()
        {
            #region Arrange
            string input = "night, 1, 1, 2, 3, 5";
            string outputExpected = "steak, error";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Night1SentitiveCaseTest()
        {
            #region Arrange
            string input = "NIGHT, 1";
            string outputExpected = "steak";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void NightAtLeastOneDishTest()
        {
            #region Arrange
            string input = "night";
            string outputExpected = "error";
            #endregion

            #region Act
            var order = _orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }
    }
}
using NUnit.Framework;
using RestaurantOrderApp.Domain.Services;

namespace RestaurantOrderApp.Domain.Tests
{
    public class OrderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Morning123Test()
        {
            #region Arrange
            string input = "morning, 1, 2, 3";
            string outputExpected = "eggs, toast, coffee";
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
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
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
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
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Morning12333Test()
        {
            #region Arrange
            string input = "morning, 1, 2, 3, 4";
            string outputExpected = "eggs, toast, coffee(x3)";
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
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
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
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
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }

        [Test]
        public void Night1235Test()
        {
            #region Arrange
            string input = "night, 1, 2, 2, 4";
            string outputExpected = "steak, potato, wine, error";
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
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
            var orderService = new OrderService();
            #endregion

            #region Act
            var order = orderService.Get(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, order.Output);
            #endregion
        }
    }
}
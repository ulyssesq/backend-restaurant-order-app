using NUnit.Framework;
using RestaurantOrderApp.Domain.Services;
using System;

namespace RestaurantOrderApp.Domain.Tests
{
    public class ValidationServiceTests
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
            bool outputExpected = true;
            var validationService = new ValidationService();
            #endregion

            #region Act
            var isValid = validationService.IsValid(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }

        [Test]
        public void EmptyTest()
        {
            #region Arrange
            string input = String.Empty;
            bool outputExpected = false;
            var validationService = new ValidationService();
            #endregion

            #region Act
            var isValid = validationService.IsValid(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }

        [Test]
        public void SpaceTest()
        {
            #region Arrange
            string input = " ";
            bool outputExpected = false;
            var validationService = new ValidationService();
            #endregion

            #region Act
            var isValid = validationService.IsValid(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }

        [Test]
        public void NoDishesTest()
        {
            #region Arrange
            string input = "morning";
            bool outputExpected = false;
            var validationService = new ValidationService();
            #endregion

            #region Act
            var isValid = validationService.IsValid(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }

        [Test]
        public void WrongTimeOfDayTest()
        {
            #region Arrange
            string input = "afternoon, 1, 2";
            bool outputExpected = false;
            var validationService = new ValidationService();
            #endregion

            #region Act
            var isValid = validationService.IsValid(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }
    }
}

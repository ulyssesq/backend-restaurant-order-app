using NUnit.Framework;
using RestaurantOrderApp.Domain.Interfaces.Services;
using System;

namespace RestaurantOrderApp.Domain.Tests
{
    public class ValidationServiceTests : BaseTest
    {
        private IValidationService _validationService;

        [SetUp]
        public void Setup()
        {
            _validationService = (IValidationService)ServiceProvider.GetService(typeof(IValidationService));
        }

        [Test]
        public void Morning123Test()
        {
            #region Arrange
            string input = "morning, 1, 2, 3";
            bool outputExpected = true;
            #endregion

            #region Act
            var isValid = _validationService.IsValid(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }

        [Test]
        public void Night12Test()
        {
            #region Arrange
            string input = "night, 1, 2";
            bool outputExpected = true;
            #endregion

            #region Act
            var isValid = _validationService.IsValid(input);
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
            #endregion

            #region Act
            var isValid = _validationService.IsValid(input);
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
            #endregion

            #region Act
            var isValid = _validationService.IsValid(input);
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
            #endregion

            #region Act
            var isValid = _validationService.IsValid(input);
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
            #endregion

            #region Act
            var isValid = _validationService.IsValid(input);
            #endregion

            #region Assert
            Assert.AreEqual(outputExpected, isValid);
            #endregion
        }
    }
}
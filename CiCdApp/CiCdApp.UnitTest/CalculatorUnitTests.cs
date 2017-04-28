using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiCdApp.Test
{
    [TestClass]
    public class CalculatorUnitTests
    {
        private CalculatorPageModel _pageModel;

        [TestInitialize]
        public void Initialize()
        {
            _pageModel = new CalculatorPageModel();
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange
            _pageModel.ValueA = 20;
            _pageModel.ValueB = 22;

            // Act
            _pageModel.AddCommand.Execute(null);

            // Assert
            Assert.AreEqual(42, _pageModel.Result);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            _pageModel.ValueA = 6;
            _pageModel.ValueB = 7;

            // Act
            _pageModel.MultiplyCommand.Execute(null);

            // Assert
            Assert.AreEqual(42, _pageModel.Result);
        }

        [TestMethod]
        public void AnswerToEverythingTest()
        {
            // Arrange
            // Nothing to arrange for this test

            // Act
            _pageModel.AnswerToEverythingCommand.Execute(null);

            // Assert
            Assert.AreEqual(42, _pageModel.Result);
        }
    }
}
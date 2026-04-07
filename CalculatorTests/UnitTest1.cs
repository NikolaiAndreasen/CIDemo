using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Calculator.Calculator _calc = new Calculator.Calculator();

        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = 20;

            // Act
            int result = _calc.Add(a, b);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        [DataRow(10, 2, 20)]
        [DataRow(5, 0, 0)]
        [DataRow(-2, 4, -8)]
        public void Multiply_ShouldReturnCorrectProduct(int a, int b, int expected)
        {
            int result = _calc.Multiply(a, b);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ShouldThrowException()
        {
            _calc.Divide(10, 0);
        }
    }
}
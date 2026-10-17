using Microsoft.VisualStudio.TestTools.UnitTesting;
using KushninCalculatorLib;
using System;

namespace KushninCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator = null!;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            double result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_NegativeAndPositive_ReturnsSum()
        {
            double result = _calculator.Add(-5, 3);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            double result = _calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            double result = _calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Multiply_ByZero_ReturnsZero()
        {
            double result = _calculator.Multiply(5, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            double result = _calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            try
            {
                _calculator.Divide(10, 0);
                Assert.Fail("Ожидалось исключение DivideByZeroException, но его не было");
            }
            catch (DivideByZeroException)
            {
            }
        }

        [TestMethod]
        public void Power_BaseAndExponent_ReturnsResult()
        {
            double result = _calculator.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Power_ZeroExponent_ReturnsOne()
        {
            double result = _calculator.Power(5, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calculate_Addition_ReturnsSum()
        {
            double result = _calculator.Calculate(7, 3, "+");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Calculate_Subtraction_ReturnsDifference()
        {
            double result = _calculator.Calculate(7, 3, "-");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Calculate_Multiplication_ReturnsProduct()
        {
            double result = _calculator.Calculate(7, 3, "*");
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void Calculate_Division_ReturnsQuotient()
        {
            double result = _calculator.Calculate(12, 4, "/");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Calculate_Power_ReturnsResult()
        {
            double result = _calculator.Calculate(2, 5, "^");
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void Calculate_UnknownOperation_ThrowsException()
        {
            try
            {
                _calculator.Calculate(2, 3, "%");
                Assert.Fail("Ожидалось исключение ArgumentException, но его не было");
            }
            catch (ArgumentException)
            {
            }
        }
    }
}
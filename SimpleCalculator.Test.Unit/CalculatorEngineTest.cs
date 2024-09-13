using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubstractsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("substract", number1, number2);
            Assert.AreEqual(-1, result);

        }
        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 0;
            double result = _calculatorEngine.Calculate("divides", number1, number2);
            Assert.IsTrue(double.IsInfinity(result));

        }
        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void RaisedTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("raised", number1, number2);
            Assert.AreEqual(8, result);

        }
}
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorOperation.Tests
{
    [TestClass]
    public class CalculatorOperationsTests
    {
        [TestMethod]
        public void ShouldReturnNineWhenFourAndFiveAreAdded()
        {
            CalculatorOperations co = new CalculatorOperations();
            int result= co.Add(5, 4);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void ShouldReturnTwentyWhenFourAndFiveAreMultiplied()
        {
            CalculatorOperations co = new CalculatorOperations();
            int result = co.Multiply(5, 4);
            Assert.AreEqual(20, result);
        }
    }
}

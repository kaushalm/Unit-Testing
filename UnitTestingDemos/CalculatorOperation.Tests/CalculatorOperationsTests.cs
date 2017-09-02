using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

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

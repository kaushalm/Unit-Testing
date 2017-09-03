using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Nunit.Tests
{[TestFixture]
    public class CalculatorOperationTest
    {
        [Test]
        public void ShouldReturnNineWhenFourAndFiveAreAdded()
        {
            CalculatorOperations co = new CalculatorOperations();
            int result = co.Add(5, 4);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void ShouldReturnTwentyWhenFourAndFiveAreMultiplied()
        {
            CalculatorOperations co = new CalculatorOperations();
            int result = co.Multiply(5, 4);
            Assert.AreEqual(20, result);
        }
    }
}

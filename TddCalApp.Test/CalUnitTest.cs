using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalApp.Library;

namespace TddCalApp.Test
{
    [TestClass]
    public class CalUnitTest
    {
        [TestMethod]
        public void ShouldReturnPositiveOnPassingTwoPositiveInteger()
        {
            Calculator TestCalculator = new Calculator();
            int num1 = 4;
            int num2 = 5;
            int result;
            result = TestCalculator.Add(num1, num2);
            Assert.AreEqual(9, result, "Test Case for Adding 4 and 5");
        }

        [TestMethod]
        public void ShouldReturnZereOnPassingOnePositiveAndOtherNegativeSameIntegers()
        {
            Calculator TestCalculator = new Calculator();
            int num1 = 4;
            int num2 = -4;
            int result;
            result = TestCalculator.Add(num1, num2);
            Assert.AreEqual(0, result, "Test Case for Adding 4 and -4");
        }
    }
}

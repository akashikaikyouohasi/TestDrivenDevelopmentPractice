using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDrivenDevelopmentUnitTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.AreEqual(10, five.amount);
        
        }
    }
}

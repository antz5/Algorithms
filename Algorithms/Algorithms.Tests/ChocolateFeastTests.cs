using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class ChocolateFeastTests
    {
        ChocolateFeast chocolates = new ChocolateFeast();

        [TestMethod]
        public void NumberOfChocolates()
        {
            int chocs = chocolates.NumberOfChocolates(10, 2, 5);
            Assert.AreEqual(6, chocs);
            Console.WriteLine("Actual: 6 and Expected: "+chocs);
        }

        [TestMethod]
        public void NumberOfChocolates2()
        {
            int chocs = chocolates.NumberOfChocolates(12, 4, 4);
            Assert.AreEqual(3, chocs);
            Console.WriteLine("Actual: 3 and Expected: " + chocs);
        }

        [TestMethod]
        public void NumberOfChocolates3()
        {
            int chocs = chocolates.NumberOfChocolates(6, 2, 2);
            Assert.AreEqual(5, chocs);
            Console.WriteLine("Actual: 5 and Expected: " + chocs);
        }
    }
}
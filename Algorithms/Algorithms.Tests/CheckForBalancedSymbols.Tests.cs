using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class CheckForBalancedSymbolsTests
    {
        BalancingSymbolsUsingStacks balance = new BalancingSymbolsUsingStacks();

        [TestMethod]
        public void IsBalanced()
        {
            bool pass = false;
            string input = "(((({ { [(<>)]} }))))";
            pass = balance.AreSymbolsBalanced(input);
            Assert.AreEqual(true, pass);
            Console.WriteLine("Actual: true and expected: " + pass);
        }

        [TestMethod]
        public void NotBalanced()
        {
            bool pass = true;
            string input = "((({ { { { { <<<<{ { { (} } }>>>} } } } })))";
            pass = balance.AreSymbolsBalanced(input);
            Assert.AreEqual(false, pass);
            Console.WriteLine("Actual: false and expected: " + pass);
        }
    }
}
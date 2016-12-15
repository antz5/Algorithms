using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class StringReverseUsingStacksTests
    {
        ReversingStringUsingStack balance = new ReversingStringUsingStack(); 

        [TestMethod]
        public void ReverseString()
        {
            string reversed = string.Empty;
            string input = "Maginificent";
            reversed = balance.Reverse(input);
            Assert.AreEqual("tnecifinigaM", reversed);
            Console.WriteLine("Actual: tnecifinigaM and expected: " + reversed);
        }       
    }
}
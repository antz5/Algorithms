using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class JuliusCaesorTests
    {

        Algorithms.JuliusCaesor julius = new Algorithms.JuliusCaesor();

        [TestMethod]
        public void TestForEncryption()
        {
            string result= julius.EncryptionCode("middle-Outz", 2);
            Assert.AreEqual("okffng-Qwvb", result);
            Console.WriteLine("Actual: okffng-Qwvb and Expected: "+result);
        }

        [TestMethod]
        public void TestForInputNull()
        {
            string result = julius.EncryptionCode(null, 1);
            Assert.AreEqual("The input is either null or empty", result);
            Console.WriteLine("Actual: The input is either null or empty and expected: "+result);
        }

        [TestMethod]
        public void TestForBlankInput()
        {
            string result = julius.EncryptionCode(string.Empty, 1);
            Assert.AreEqual("The input is either null or empty", result);
            Console.WriteLine("Actual: The input is either null or empty and expected: " + result);
        }

        [TestMethod]
        public void TestForZeroRotations()
        {
            string result = julius.EncryptionCode("middle-Outz", 0);
            Assert.AreEqual("middle-Outz", result);
            Console.WriteLine("Actual: middle-Outz and expected: " + result);
        }

        [TestMethod]
        public void TestFor26Rotations()
        {
            string result = julius.EncryptionCode("middle-Outz", 26);
            Assert.AreEqual("middle-Outz", result);
            Console.WriteLine("Actual: middle-Outz and expected: " + result);
        }
    }
}
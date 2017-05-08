using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class DetermineStringForUniqueCharacters_Tests
    {
        DetermineStringForUniqueCharacters unique = new DetermineStringForUniqueCharacters();

        [TestMethod]
        public void TestForUniqueness1()
        {
            bool success = unique.CharsInStringUnique("Alive is awesome");
            Assert.AreEqual(false, success);
        }

        [TestMethod]
        public void TestForUniqueness2()
        {
            bool success = unique.CharsInStringUnique("Live for the moment");
            Assert.AreEqual(false, success);
        }

        [TestMethod]
        public void TestForUniqueness3()
        {
            bool success = unique.CharsInStringUnique("Alive swum ");
            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestForUniqueness4()
        {
            bool success = unique.CharsInStringUnique("Alive org");
            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestForUniqueness5()
        {
            bool success = unique.CharsInStringUnique("ab cd ef ghi jk lmn ");
            Assert.AreEqual(true, success);
        }
    }
}

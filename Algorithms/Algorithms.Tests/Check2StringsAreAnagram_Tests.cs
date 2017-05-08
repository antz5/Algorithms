using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Algorithms.Tests
{

    [TestClass]
    public class Check2StringsAreAnagram_Tests
    {
        Check2StringsAreAnagrams check = new Check2StringsAreAnagrams();

        [TestMethod]
        public void TestAnagram1()
        {
            Assert.AreEqual(true, check.CheckAnagram("Silent", "Listen"));
        }

        [TestMethod]
        public void TestAnagram2()
        {
            Assert.AreEqual(true, check.CheckAnagram("post", "opts"));
        }

        [TestMethod]
        public void TestAnagram3()
        {
            Assert.AreEqual(false, check.CheckAnagram("madam", "damnit"));
        }
    }
}

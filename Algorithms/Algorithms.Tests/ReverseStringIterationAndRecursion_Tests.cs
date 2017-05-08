using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class ReverseStringIterationAndRecursion_Tests
    {
        ReverseStringIterationAndRecursion reverse = new ReverseStringIterationAndRecursion();
        [TestMethod]
        public void TestReverseStringIteration()
        {
            Assert.AreEqual("rehcaet", reverse.ReverseIteration("teacher"));
        }
        [TestMethod]
        public void TestReverseStringIteration2()
        {
            Assert.AreEqual("madam", reverse.ReverseIteration("madam"));
        }

        [TestMethod]
        public void TestReverseStringRecursion()
        {
            Assert.AreEqual("rehcaet", reverse.ReverseRecursion("teacher", "teacher".Length));
        }

        [TestMethod]
        public void TestReverseStringRecursion2()
        {
            Assert.AreEqual("madam", reverse.ReverseRecursion("madam", "madam".Length));
        }

        [TestMethod]
        public void TestReverseStringRecursion3()
        {
            Assert.AreEqual("namunah", reverse.ReverseRecursion("hanuman", "hanuman".Length));
        }

    }
}

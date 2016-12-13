using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class LinearSearchTests
    {
        LinearSearch search = new LinearSearch();

        [TestMethod]
        public void KeyPresent()
        {
            int position = -1;
            int[] input = new int[] { 5, 8, 4, 10, 2, 23 };
            position = search.Search(input, 23);

            Assert.AreEqual(5, position);
            Console.WriteLine("Actual: 5: and Expected: " + position);
        }

        [TestMethod]
        public void KeyNotPresent()
        {
            int position = -1;
                int[] input = new int[] { 1, 2, 3, 4, 3, 3, 2, 1 };

            position = search.Search(input, 23);

            Assert.AreEqual(-1, position);
            Console.WriteLine("Actual: -1: and Expected: " + position);

        }
    }
}
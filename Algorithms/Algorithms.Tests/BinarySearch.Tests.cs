using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        BinarySearchIterativeApproach search = new BinarySearchIterativeApproach();

        [TestMethod]
        public void KeyPresent1()
        {
            int position = -1;
            int[] input = new int[] {10, 15, 25, 38, 48, 185, 192 };
            position = search.Search(input, 10);

            Assert.AreEqual(0, position);
            Console.WriteLine("Actual: 0 and Expected: " + position);
        }

        [TestMethod]
        public void KeyPresent2()
        {
            int position = -1;
            int[] input = new int[] { 10, 15, 25, 38, 48, 185, 192 };
            position = search.Search(input, 192);

            Assert.AreEqual(6, position);
            Console.WriteLine("Actual: 6 and Expected: " + position);
        }

        [TestMethod]
        public void KeyPresent3()
        {
            int position = -1;
            int[] input = new int[] { 10, 15, 25, 38, 48, 185, 192 };
            position = search.Search(input, 185);

            Assert.AreEqual(5, position);
            Console.WriteLine("Actual: 5 and Expected: " + position);
        }


        [TestMethod]
        public void KeyPresent4()
        {
            int position = -1;
            int[] input = new int[] { 10, 15, 25, 38, 48, 185, 192 };
            position = search.Search(input, 25);

            Assert.AreEqual(2, position);
            Console.WriteLine("Actual:2  and Expected: " + position);
        }

        [TestMethod]
        public void KeyPresent5()
        {
            int position = -1;
            int[] input = new int[] { 10, 15, 25, 38, 48, 185, 192 };
            position = search.Search(input, 38);

            Assert.AreEqual(3, position);
            Console.WriteLine("Actual:3  and Expected: " + position);
        }

        [TestMethod]
        public void KeyNotPresent()
        {
            int position = -1;
                int[] input = new int[] { 10, 15, 25, 38, 48, 185, 192 };

            position = search.Search(input, 23);

            Assert.AreEqual(-1, position);
            Console.WriteLine("Actual: -1: and Expected: " + position);
        }
    }
}
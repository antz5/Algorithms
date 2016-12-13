using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class BubbleSortTests
    {
        BubbleSort bubble = new BubbleSort();

        [TestMethod]
        public void Sort1()
        {
            
            int[] input = new int[] { 25, 38, 15, 185, 192, 10 };
            int[] sortedItems =  bubble.BubbleSorted(input);
            int[] expectedItems = new int[] {10, 15, 25, 38, 185, 192 };
            bool success = false; 
            for (int i = 0; i < input.Length; i++)
            {
                success = false;
                if (sortedItems[i] == expectedItems[i])
                    success = true;
            }
            Assert.AreEqual(true, success);
            Console.WriteLine("Actual: true and Expected: " + success);
        }

        [TestMethod]
        public void Sort2()
        {

            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 120, 125, 190, 500 };
            int[] sortedItems = bubble.BubbleSorted(input);
            int[] expectedItems = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 120, 125, 190, 500 };
            bool success = false;
            for (int i = 0; i < input.Length; i++)
            {
                success = false;
                if (sortedItems[i] == expectedItems[i])
                    success = true;
            }
            Assert.AreEqual(true, success);
            Console.WriteLine("Actual: true and Expected: " + success);
        }

        [TestMethod]
        public void Sort3()
        {

            int[] input = new int[] {  500,  190, 130, 120, 100, 90, 80, 70, 34, 24, 12, 11, 9, 7, 5, 2, 1};
            int[] sortedItems = bubble.BubbleSorted(input);
            int[] expectedItems = new int[] { 1, 2, 5, 7,  9, 11, 12, 24, 34, 70, 80, 90, 100, 120, 130, 190, 500 };
            bool success = false;
            for (int i = 0; i < input.Length; i++)
            {
                success = false;
                if (sortedItems[i] == expectedItems[i])
                    success = true;
            }
            Assert.AreEqual(true, success);
            Console.WriteLine("Actual: true and Expected: " + success);
        }
    }
}
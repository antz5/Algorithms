using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class SticksTests
    {
        CutTheSticks cutSticks = new CutTheSticks();

        [TestMethod]
        public void SticksCut()
        {
            bool pass = false;
            int[] input = new int[] { 5, 4, 4, 2, 2, 8 };
            List<int> result = cutSticks.Sticks(6, input);
            for (int i = 0; i < result.Count; i++)
            {
                if (result.Contains(6) && result.Contains(4) && result.Contains(2) && result.Contains(1))
                {
                    pass = true;
                }
            }

            Assert.AreEqual(true, pass);
            Console.WriteLine("Actual: true and expected: " + pass);
        }

        [TestMethod]
        public void SticksCut2()
        {
            bool pass = false;
            int[] input = new int[] { 1, 2, 3, 4, 3, 3, 2, 1 };

            List<int> result = cutSticks.Sticks(8, input);
            for (int i = 0; i < result.Count; i++)
            {
                if (result.Contains(8) && result.Contains(6) && result.Contains(4) && result.Contains(1))
                {
                    pass = true;
                }
            }

            Assert.AreEqual(true, pass);
            Console.WriteLine("Actual: true and expected: " + pass);
        }
    }
}
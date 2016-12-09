using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestClass]
    public class AlternatingCharactersTest
    {

        Algorithms.AlternatingCharacters altChars = new Algorithms.AlternatingCharacters();
        [TestMethod]
        public void TestAlternatingCharacters()
        {
            
            string input = "ABCBADDFFS";
            int numberOfDeletions = altChars.DeletionsRequired(input);
            if (numberOfDeletions > 0)
            {
                Assert.AreEqual(2, numberOfDeletions);
            }
        }

        [TestMethod]
        public void TestAlternatingCharacters2()
        {
            string input = "BBBBB";
            int numberOfDeletions = altChars.DeletionsRequired(input);
            if (numberOfDeletions > 0)
            {
                Assert.AreEqual(4, numberOfDeletions);
            }
        }        
    }
}
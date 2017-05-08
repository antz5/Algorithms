using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class CountWordsInString_Tests
    {
        CountWordsInString count = new CountWordsInString();
        [TestMethod]
        public void TestNumberOfWords()
        {
            int num = count.CountWords("Hey there! It's been an honor to break out. As soon as  lights go  off I am gone. ");
            Assert.AreEqual(18, num);
        }
    }
}

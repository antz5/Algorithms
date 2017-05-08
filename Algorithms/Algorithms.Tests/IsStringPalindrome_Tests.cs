using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class IsStringPalindrome_Tests
    {
        IsStringPalindrome palindrome = new IsStringPalindrome();
        [TestMethod]
        public void TestPalindrome1()
        {
            bool isPalindrome = palindrome.IsPalindrome("civic");
            Assert.AreEqual(true, isPalindrome);
        }

        [TestMethod]
        public void TestPalindrome2()
        {
            bool isPalindrome = palindrome.IsPalindrome("teacher");
            Assert.AreEqual(false, isPalindrome);
        }

        [TestMethod]
        public void TestPalindrome3()
        {
            bool isPalindrome = palindrome.IsPalindrome("madam");
            Assert.AreEqual(true, isPalindrome);
        }

        [TestMethod]
        public void TestPalindrome4()
        {
            bool isPalindrome = palindrome.IsPalindrome("Algorithm");
            Assert.AreEqual(false, isPalindrome);
        }

        [TestMethod]
        public void TestPalindrome5()
        {
            bool isPalindrome = palindrome.IsPalindrome("kumar");
            Assert.AreEqual(false, isPalindrome);
        }

        [TestMethod]
        public void TestPalindrome6()
        {
            bool isPalindrome = palindrome.IsPalindrome("kayak");
            Assert.AreEqual(true, isPalindrome);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class RemoveDuplicateCharactersTests
    {
        RemoveDuplicateCharacters removeObject = new RemoveDuplicateCharacters();
        [TestMethod]
        public void TestForRemoveDuplicateChars()
        {

            Assert.AreEqual("CSharpt", removeObject.Remove("CSharpStars"));
            Console.WriteLine(removeObject.Remove("CSharpStars").Equals("CSharpt"));
			
        }

		[TestMethod]
        public void TestForRemoveDuplicateChars2()
        {
            Assert.AreEqual("CN", removeObject.Remove("CNN"));
            Console.WriteLine(removeObject.Remove("CNN").Equals("CN"));

        }

        [TestMethod]
        public void TestForRemoveDuplicateChars3()
        {
            Assert.AreEqual("Gole", removeObject.Remove("GoOgle"));
            Console.WriteLine(removeObject.Remove("GoOgle").Equals("Gole"));


        }

		[TestMethod]
        public void TestForRemoveDuplicateChars4()
        {
            Assert.AreEqual("Yaho", removeObject.Remove("Yahoo"));
            Console.WriteLine(removeObject.Remove("Yaho").Equals("Yahoo"));
        }
    }
}

using System;
using System.Collections.Generic;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //If 3 Fizz
        //if 5 Buzz
        [TestMethod]
        public void TestThreeTrue()
        {
            var multipleCheck = new MultipleCheck();
            Assert.IsTrue(multipleCheck.ThreeCheck(6));
        }

        [TestMethod]
        public void TestThreeFalse()
        {
            var multipleCheck = new MultipleCheck();
            Assert.IsFalse(multipleCheck.ThreeCheck(5));
        }

        [TestMethod]
        public void TestFiveCheckTrue()
        {
            var multipleCheck = new MultipleCheck();
            Assert.IsTrue(multipleCheck.FiveCheck(50));
        }

        [TestMethod]
        public void TestFiveCheckFalse()
        {
            var multipleCheck = new MultipleCheck();
            Assert.IsFalse(multipleCheck.FiveCheck(51));
        }

        [TestMethod]
        public void TestAnyCheckTrue()
        {
            var multipleCheck = new MultipleCheck();
            Assert.IsTrue(multipleCheck.AnyCheck(11, 66));
        }

        [TestMethod]
        public void TestAnyCheckFalse()
        {
            var multipleCheck = new MultipleCheck();
            Assert.IsFalse(multipleCheck.AnyCheck(11, 65));
        }

        [TestMethod]
        public void TestCheckMultiples()
        {
            //limit max is  2,147,483,647 that is, hexadecimal 0x7FFFFFFF.

            var multipleCheck = new MultipleCheck();
            Dictionary<int, string> dictionary =
                new Dictionary<int, string>();

            dictionary.Add(3, "Fizz");
            dictionary.Add(5, "Buzz");
            dictionary.Add(2, "Even");
            var result = multipleCheck.checkMultiples(10, dictionary);
            Assert.AreEqual("2 Even\n3 Fizz\n4 Even\n5 Buzz\n6 Fizz Even\n7\n8 Even\n9 Fizz\n10 Buzz Even\n", result);
        }
    }
}
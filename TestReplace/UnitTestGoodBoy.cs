using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskFlexibase;
using MuzzGuzz;
using GoodBoy;

namespace TestReplace
{
    [TestClass]
    public class UnitTestGoodBoy
    {
        [TestMethod]
        public void Default()
        {
            List<int> input = new List<int>
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            string expected = "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, " +
                "dog-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz";
            NumberReplacer replacer = new Good_BoyReplacer();
            string result = replacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NumbersIsNull()
        {
            string expected = String.Empty;
            NumberReplacer replacer = new Good_BoyReplacer();
            string result = replacer.ReplaceString(null);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy3()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 3, 6, 9, 81 };
            string expected = "dog, dog, dog, dog";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy5()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 5, 10, 2005, 25 };
            string expected = "cat, cat, cat, cat";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy3And5()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 15, 30, 45, 60 };
            string expected = "good-boy, good-boy, good-boy, good-boy-muzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NumberIsDivisibleBy4()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 4, 8, 16, 32 };
            string expected = "muzz, muzz, muzz, muzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy7()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 7, 14, 28, 49 };
            string expected = "guzz, guzz, muzz-guzz, guzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy3And4()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 12, 24, 48, 72 };
            string expected = "dog-muzz, dog-muzz, dog-muzz, dog-muzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy3And5And7()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 105, 210, 315, 420 };
            string expected = "good-boy-guzz, good-boy-guzz, good-boy-guzz, good-boy-muzz-guzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsNotDivisibleByAny()
        {
            NumberReplacer numberReplacer = new Good_BoyReplacer();
            List<int> input = new List<int> { 1, 2, 11, 13, 17, 19, 23, 26 };
            string expected = "1, 2, 11, 13, 17, 19, 23, 26";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }




    }
}

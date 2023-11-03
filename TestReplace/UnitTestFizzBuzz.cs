using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskFlexibase;


namespace FizzBuzz
{
    
    [TestClass]
    public class UnitTestFizzBuzz
    {
        [TestMethod]
        public void Default()
        {
            List<int> input = new List<int>
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string expected = "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz";
            NumberReplacer replacer = new Fizz_BuzzReplacer();
            string result = replacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumbersIsNull()
        {
            string expected = String.Empty;
            NumberReplacer replacer = new Fizz_BuzzReplacer();
            string result = replacer.ReplaceString(null);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NumberIsDivisibleBy3()
        {
            NumberReplacer numberReplacer = new Fizz_BuzzReplacer();
            List<int> input = new List<int> { 3, 6, 9, 12 };
            string expected = "fizz, fizz, fizz, fizz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NumberIsDivisibleBy5()
        {
            NumberReplacer numberReplacer = new Fizz_BuzzReplacer();
            List<int> input = new List<int> { 5, 10, 20, 25 };
            string expected = "buzz, buzz, buzz, buzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NumberIsDivisibleBy3And5()
        {
            NumberReplacer numberReplacer = new Fizz_BuzzReplacer();
            List<int> input = new List<int> { 15, 30, 45, 60 };
            string expected = "fizz-buzz, fizz-buzz, fizz-buzz, fizz-buzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsNotDivisibleBy3Or5()
        {
            NumberReplacer numberReplacer = new Fizz_BuzzReplacer();
            List<int> input = new List<int> { 1, 2, 4, 7, 8, 11, 13, 14 };
            string expected = "1, 2, 4, 7, 8, 11, 13, 14";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskFlexibase;


namespace MuzzGuzz
{

    [TestClass]
    public class UnitTestMuzzGuzz
    {
        [TestMethod]
        public void Default()
        {
            List<int> input = new List<int>
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            string expected = "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, " +
                "guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz";
            NumberReplacer replacer = new Muzz_GuzzReplacer();
            string result = replacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NumbersIsNull()
        {
            string expected = String.Empty;
            NumberReplacer replacer = new Muzz_GuzzReplacer();
            string result = replacer.ReplaceString(null);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy3()
        {
            NumberReplacer numberReplacer = new Muzz_GuzzReplacer();
            List<int> input = new List<int> { 3, 6, 9, 81 };
            string expected = "fizz, fizz, fizz, fizz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy5()
        {
            NumberReplacer numberReplacer = new Muzz_GuzzReplacer();
            List<int> input = new List<int> { 5, 10, 2005, 25 };
            string expected = "buzz, buzz, buzz, buzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy4()
        {
            NumberReplacer numberReplacer = new Muzz_GuzzReplacer();
            List<int> input = new List<int> { 4, 8, 16, 32 };
            string expected =  "muzz, muzz, muzz, muzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy7()
        {
            NumberReplacer numberReplacer = new Muzz_GuzzReplacer();
            List<int> input = new List<int> { 7, 14, 28, 49 };
            string expected = "guzz, guzz, muzz-guzz, guzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy3And4()
        {
            NumberReplacer numberReplacer = new Muzz_GuzzReplacer();
            List<int> input = new List<int> { 12, 24, 48, 72 };
            string expected = "fizz-muzz, fizz-muzz, fizz-muzz, fizz-muzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsDivisibleBy3And5And7()
        {
            NumberReplacer numberReplacer = new Muzz_GuzzReplacer();
            List<int> input = new List<int> { 105, 210, 315, 420 };
            string expected = "fizz-buzz-guzz, fizz-buzz-guzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NumberIsNotDivisibleByAny()
        {
            NumberReplacer numberReplacer = new Muzz_GuzzReplacer();
            List<int> input = new List<int> { 1, 2, 11, 13, 17, 19, 23, 26 };
            string expected = "1, 2, 11, 13, 17, 19, 23, 26";
            string result = numberReplacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }




    }
}
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
            string expected = "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz";
            NumberReplacer replacer = new Muzz_GuzzReplacer();
            string result = replacer.ReplaceString(input);
            Assert.AreEqual(expected, result);
        }
    }
}
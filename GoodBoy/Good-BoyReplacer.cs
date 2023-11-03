using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskFlexibase;
using MuzzGuzz;

namespace GoodBoy
{
    public class Good_BoyReplacer:Muzz_GuzzReplacer
    {
        public Good_BoyReplacer():base() {}

        public override string ReplaceString(List<int> numbers)
        {
            string originalString = base.ReplaceString(numbers);
            string[] oldWords = new string[] { "fizz-buzz", "fizz", "buzz" };
            string[] newWords = new string[] { "good-boy", "dog", "cat" };
            for (int i = 0; i < oldWords.Length; i++)
            {
                while (originalString.Contains(oldWords[i]))
                {
                    originalString = originalString.Replace(oldWords[i], newWords[i]);
                }
            }

            return originalString;

        }

    }
}

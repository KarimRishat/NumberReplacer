using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskFlexibase
{
    internal class NumberReplacer
    {
        private List<Strategy> strategyList;
        public string NewString(int num)
        {
            string result = "";
            foreach (Strategy strategy in strategyList)
            {
                if (strategy.NeedReplace(num))
                {
                    result.Insert(result.Length - 1, strategy.Replace());
                    result.Insert(result.Length - 1, "-");
                }
            }
            return result.Substring(0,result.Length-1);
        }
    }
}

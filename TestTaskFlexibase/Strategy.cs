using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskFlexibase
{
    internal class Strategy
    {
        private string replace_string;
        private uint Divider;
        public Strategy(string text, int divider) { 
            replace_string = text;
            if(divider > 0) { 
                Divider = (uint)divider; 
            }

            else {
                throw new ArgumentOutOfRangeException("Делитель должен быть больше нуля");
            }
        }
        public bool NeedReplace(int number)
        {
            bool fizz = false;
            if (number % Divider == 0)
                fizz = true;
            return fizz;
        }

        public string Replace()
        {
            return replace_string;
        }
    }
}

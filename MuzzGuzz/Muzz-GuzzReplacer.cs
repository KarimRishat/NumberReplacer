using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskFlexibase;

namespace MuzzGuzz
{
    public class Muzz_GuzzReplacer:Fizz_BuzzReplacer
    {
        public Muzz_GuzzReplacer()
            :base() 
        {
            AddMuzzGuzz();
        }

        private void AddMuzzGuzz()
        {
            AddStrategy("muzz", 4);
            AddStrategy("guzz", 7);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Class3
    {
        /* Step 4: Declare a method for calling the delegate */
        public void callDelegate(MyDelegate d,string input)
        {
            d(input);
        }
    }
}

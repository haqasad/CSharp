using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Class1
    {
        /* Step 2: Define methods that match with signature of delegate declaration */
        public void delegateMethod1(string input)
        {
            Console.WriteLine("This is delegateMethod1 and the input to the method is {0}", input);
        }

        public void delegateMethod2(string input)
        {
            Console.WriteLine("This is delegateMethod2 and the input to the method is {0}", input);
        }
    }
}

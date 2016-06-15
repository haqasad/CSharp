using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Class2
    {
        /* Step 3: Create delegate object and plug in the methods */
        public MyDelegate createDelegateMethod()
        {
            Class1 C1 = new Class1();
            MyDelegate D1 = new MyDelegate(C1.delegateMethod1);
            MyDelegate D2 = new MyDelegate(C1.delegateMethod2);
            MyDelegate D3 = D1 + D2;
            return D3;
        }
    }
}

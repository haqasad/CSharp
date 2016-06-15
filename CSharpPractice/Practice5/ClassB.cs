using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class ClassB
    {
        public event MyHandler1 Event1;
        public event MyHandler2 Event2;

        public void FireEvent1(MyEventArgs e)
        {
            if (Event1 != null)
            {
                Event1(this,e);
            }
        }

        public void FireEvent2(MyEventArgs e)
        {
            if (Event2 != null)
            {
                Event2(this,e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class ClassA
    {
        public const string m_id = "Class A";

        public void OnHandler1(object sender, MyEventArgs e)
        {
            Console.WriteLine("I am in OnHandler1 and MyEventArgs is {0}", e.m_id);
        }

        public void OnHandler2(object sender, MyEventArgs e)
        {
            Console.WriteLine("I am in OnHandler2 and MyEventArgs is {0}", e.m_id);
        }

        public ClassA(ClassB b)
        {
            MyHandler1 d1 = new MyHandler1(OnHandler1);
            MyHandler2 d2 = new MyHandler2(OnHandler2);
            b.Event1 += d1;
            b.Event2 += d2;
        }
    }
}

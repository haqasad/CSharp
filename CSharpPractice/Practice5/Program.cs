using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            ClassA a = new ClassA(b);
            MyEventArgs e1 = new MyEventArgs();
            MyEventArgs e2 = new MyEventArgs();
            e1.m_id = "Event args for event 1";
            e2.m_id = "Event args for event 2";
            b.FireEvent1(e1);
            b.FireEvent2(e2);
            Console.ReadKey();
        }
    }
}

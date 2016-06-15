/* Example of Event Handler in C# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    /* Step 1: CREATE DELEGATE
     * 
     * public delegate void MyHandler1(object sender, MyEventArgs e)
     * public delegate void MyHandler1(object sender, MyEventArgs e) */


    /* Step 2: CREATE EVENT HANDLER METHODS
     * 
     * class ClassA
     * {
     *      public const string m_id = "Class A";
     *      public void OnHandler1(object sender, MyEventArgs e)
     *      {
     *          Console.WriteLine("I am in OnHandler1 and MyEventArgs is {0}", e.m_id;
     *      }
     *      
     *      public void OnHandler2() { }
     * } */


    /* Step 3: CREATE DELEGATE OBJECTS, PLUG IN THE HANDLER AND REGISTER WITH THE OBJECT THAT
     * WILL FIRE THE EVENTS
     * 
     * public ClassA(ClassB b)
     * {
     *      MyHandler1 d1 = new MyHandler(OnHandler1);
     *      MyHandler2 d2 = new MyHandler(OnHandler2);
     *      b.Event1 += d1;
     *      b.Event2 += d2;
     * } */


    /* Step 4: CALLS THE ENCAPSULATED METHODS THROUGH THE DELEGATES (FIRES EVENTS)
     * 
     * public event MyHandler1 Event1;
     * public event MyHandler2 Event2;
     * 
     * public void FireEvent1(MyEventArgs e)
     * {
     *      if (Event1 != null)
     *      {
     *          Event1(this,e);
     *      }
     * }
     * 
     * public void FireEvent2(MyEventArgs e) { } */ 


     /* public class MyEventArgs: EventArgs { public string m_id; } */


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

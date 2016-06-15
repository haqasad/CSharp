/* Example of Delegate in C# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Step 1: Declare a delegate with the signature of the encapsulated method
             * delegate void MyDelegate(string input); */

            /* Step 2: Define methods that match with signature of delegate declaration
             * Class1
             * {
             *      public void delegateMethod1(string input)
                    {
                        Console.WriteLine("This is delegateMethod1 and the input to the method is {0}", input);
                    }

                    public void delegateMethod2(string input)
                    {
                        Console.WriteLine("This is delegateMethod2 and the input to the method is {0}", input);
                    }
                } */

            /* Step 3: Create delegate object and point to the encapsulated methods
             * Class2
             * {
             *      public MyDelegate createDelegate()
                    {
                        Class1 C1 = new Class1();
                        MyDelegate D1 = new MyDelegate(C1.delegateMethod1);
                        MyDelegate D2 = new MyDelegate(C1.delegateMethod2);
                        MyDelegate D3 = D1 + D2;
                        return D3;
                     }
                 } */

            /* Step 4: Declare a method for calling the delegate
             * Class3
             * {
             *      public void callDelegate(MyDelegate d,string input)
                    {
                        d(input);
                    }
                } */

            /* Step 5: Call the encapsulated methods through the delegate */
            Class2 CreateDelegateObject = new Class2();
            MyDelegate MyDelegateField = CreateDelegateObject.createDelegateMethod();
            Class3 CallDelegate = new Class3();
            CallDelegate.callDelegate(MyDelegateField, "Hello World!");
            Console.ReadKey();
        }
    }
}

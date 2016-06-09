// Including the class 'System'. Methods used in the Main method belongs to the System class

using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

/* The concept of namespace is similar to packages in java. It can hold multiple class files.
 * Java accesses jar file (or packages are compressed as jar file)
 * C# accesses dll file (or namespaces are compressed as dll file)
 * Each project can be considered as a package or namespace. This concept is called Modular Programming
 * Here under Practice1, HelloWorldApp is a class. Also multiple classes (or items like XML) can be added under Practice1 */
namespace Practice1 
{
    class Test
    {
        //int v;
        //public Test() { };
        //public Test() { v = a; }    
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!\n\n");

            //string s = ".NET";
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.Length);

            //Console.WriteLine("\n\n");

            /* Calling class Counter */

            //Counter c = new Counter(5);
            //c.Inc();
            //c.Inc();
            //Console.WriteLine(c.Count);
            //Counter d = new Counter(7);
            //d.Inc();
            //Console.WriteLine(d.Count);
            //Console.WriteLine("\n\n");

            /* Array Example */

            //int[] numbers = new int[5];
            //string[,] names = new string[5, 4];
            //byte[][] scores = new byte[5][];

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    scores[i] = new byte[i + 3];
            //}
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            //}

            /* Implementation of Delegate: ConvertsIntToString.cs
             * Delegate adds a new type to the project
             * Type 'ConvertsIntToString' has been added to the project Practice1
             * Instead of referencing to an object, delegate references to a method
             * The referenced method should have the same signature (return type and argument type) as the delegate
             * ConvertsIntToString delegate points to a method HiThere in the class Program.cs
             * To use the method using delegate, NO NEED TO INSTANTIATE THE CLASS (HiThere method should be static)
             * Same output can be achieved by instantiating the Program class (HiThere method should be non-static) */

            ConvertsIntToString someMethod = new ConvertsIntToString(Program.HiThere);
            string message = someMethod(6);
            Console.WriteLine(message);

            //Program Check = new Program();
            //string message = Check.HiThere(4);
            //Console.WriteLine(message);



            Console.ReadKey();
        }
    }
}
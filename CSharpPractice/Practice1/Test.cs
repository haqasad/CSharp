// Including the class 'System'. Methods used in the Main method belongs to the System class

using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

// The concept of namespace is similar to packages in java. It can hold multiple class files.
// Java accesses jar file (or packages are compressed as jar file)
// C# accesses dll file (or namespaces are compressed as dll file)
// Each project can be considered as a package or namespace. This concept is called Modular Programming
// Here under Practice1, HelloWorldApp is a class. Also multiple classes (or items like XML) can be added under Practice1
namespace Practice1 
{
    class Test
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = ".NET";
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Length);

            Counter c = new Counter(5);
            c.Inc();
            c.Inc();
            Console.WriteLine(c.Count);
            Counter d = new Counter(7);
            d.Inc();
            Console.WriteLine(d.Count);
            Console.ReadLine();
        }
    }
}

using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Literal();
        }

        static void Varaibles() {
            // type name
            string name;

            // set value
            name = "Tom";

            System.Console.WriteLine(name);

            // initialization during declaration
            string name1 = "Evgenii";
            Console.WriteLine(name1);
        }

        static void Literal() {
            // logic
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine();

            // integer
            Console.WriteLine(-11);
            Console.WriteLine(555);
            Console.WriteLine();

            // floating point
            Console.WriteLine(3.14);
            Console.WriteLine(-273.15);
            Console.WriteLine();

            // symbol
            Console.Write('A');
            Console.Write('\t');
            Console.WriteLine('t');
            Console.WriteLine();

            // string
            Console.WriteLine("Hello world");
            Console.WriteLine();
        }
    }
}

using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTypes();
        }

        static void Varaibles()
        {
            // type name
            string name;

            // set value
            name = "Tom";

            System.Console.WriteLine(name);

            // initialization during declaration
            string name1 = "Evgenii";
            Console.WriteLine(name1);
        }

        static void Literal()
        {
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

        static void DataTypes()
        {
            bool alive = true; // value type 
            Console.WriteLine(alive);

            byte bt = 255; // value type
            sbyte sbt = -128; // value type
            Console.WriteLine
            (
                bt.ToString()
                + '\t'
                + sbt.ToString()
                );

            short s = 30000; // value type
            ushort us = 60000; // value type
            Console.WriteLine
            (
                s.ToString()
                + '\t'
                + us.ToString()
                );

            int i = -200000000; // value type
            uint ui = 4000000000; // value type
            Console.WriteLine
            (
                i.ToString()
                + '\t'
                + ui.ToString()
                );

            long l = -3000; // value type
            ulong ul = 30000; // value type
            Console.WriteLine
            (
                l.ToString()
                + '\t'
                + ul.ToString()
                );

            char c = '\x0420'; // value type
            string str = "hello"; // reference type
            Console.WriteLine
            (
                c.ToString()
                + '\t'
                + str.ToString()
                );

            float f = 3.123f; // value type
            double d = 3.134; // value type
            decimal dcml = 1023.32M; // value type, structure Decimal - floating point number which is able to be involved in financial operations
            Console.WriteLine
            (
                f.ToString()
                + '\t'
                + d.ToString()
                + '\t'
                + dcml.ToString()
                );
        }
    }
}

using System;

namespace Delegates
{
    class Program
    {
        delegate void mathfunc(); //creating a template for a method call, type for a method, treat methods more like data

        static void Main(string[] args)
        {
            mathfunc method;
            //set method to print method
            method = Print;
            method();
            method = Write;
            method();

            mathfunc[] mets = { Print, Write };
            foreach (var i in mets)
            {
                i();
            }
        }

        static void Print()
        {
            Console.WriteLine("Print");
        }

        static void Write()
        {
            Console.WriteLine("Write");
        }

        static void Calc(int i)
        {

        }
    }
}

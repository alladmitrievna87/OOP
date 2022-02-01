using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           Lab work №1");
            Console.WriteLine("");
            Console.WriteLine("  Console appendix structure in С#");
            Console.WriteLine("");
            Console.WriteLine("      Pinchuk Alla Dmytrivna");
            Console.WriteLine("       KI-241, 172 specialty");
            Console.WriteLine("");
            Console.WriteLine("            Variant 1");
            Console.WriteLine("");
            Console.WriteLine("Task 2");
            Console.WriteLine("");
            double x = 0.31; // first value
            double y = -0.0049;
            double A = Math.Sqrt(Math.Log((double)4 / 3 + x) + (double)9 / 7) - Math.Pow(Math.E, -1 * Math.Sin(1.3 * x - 0.7));// math expression
            Console.WriteLine($" x = {x}, y = {y}, A = {A}");// output result
            double x1 = 2.5;// second value
            double A1 = Math.Sqrt(Math.Log((double)4 / 3 + x1) + (double)9 / 7) - Math.Pow(Math.E, -1 * Math.Sin(1.3 * x - 0.7)); //math expression
            Console.WriteLine($" x1 = {x1}, A1 = {A1}"); //output result
            
        }
    }
}
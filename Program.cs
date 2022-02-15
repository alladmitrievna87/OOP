using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            
            //input and formatting data 
             int A; // = -14
             float I; // = -10^4
             double C; // = -0.00151 
             bool L; // = false
             string N; // ="Pinchuk"
             Console.WriteLine("Input surname");
             N = Console.ReadLine();
             Console.WriteLine("Input A");
             A = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input I");
             I = Convert.ToSingle(Console.ReadLine());
             Console.WriteLine("Input C");
             C = double.Parse(Console.ReadLine());
             Console.WriteLine("Input L");
             L = Convert.ToBoolean(Console.ReadLine());

             //Output formatting results
             Console.WriteLine();
             Console.WriteLine("Formatting results");
             Console.WriteLine();
             Console.WriteLine($"surname = {N},L = {L}");
             Console.WriteLine($"A = {A}, C = {C}, I = {I}");
             Console.WriteLine();
             Console.WriteLine("For exit press Enter");
             Console.ReadLine();
           
            #endregion

            #region Task 2
            
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("Lab2.RES");
            StreamReader f1 = new StreamReader("LAB2.txt");
            f.WriteLine("Table of values");
            f.WriteLine("I---------------------------------------------------------I");
            f.WriteLine("I  Argument X             I         Function Y            I");
            f.WriteLine("I---------------------------------------------------------I");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = double.Parse(s);
            y = (1 - Math.Pow(x, 2)) / (1 + Math.Pow(x, 4));
            f.WriteLine($"I  x = {x:f2}              I          y = {y:f3}           I");
            goto metka;
        metka1: f.WriteLine("I---------------------------------------------------------I");
            f.WriteLine("Prepared by Pinchuk Alla");
            f.Close();
            f1.Close();
            
            #endregion

        }
    }
}

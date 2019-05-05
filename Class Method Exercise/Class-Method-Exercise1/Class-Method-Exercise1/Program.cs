using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Page 111

            Console.WriteLine("Please choose the first number you would like to do Math operations on: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the second number you would like to do Math operations on: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Numbers1 a = new Numbers1(x, y);

            Console.WriteLine("Adding them together: ");
            Console.WriteLine(a.Add());

            Console.WriteLine("Subtracting them: ");
            Console.WriteLine(a.Mult());

            Console.WriteLine("Dividing them: ");
            Console.WriteLine(a.Sub());

            Console.WriteLine("Multiplying them: ");
            Console.WriteLine(a.Divide());

            a.print();
            Console.ReadLine();
        }
    }
}

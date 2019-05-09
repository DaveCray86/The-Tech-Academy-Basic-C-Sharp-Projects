using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page114_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We meet again...");
            Console.WriteLine(Class1.Op1(5));

            Class1 e = new Class1(3, 55.23423525m, "20");           //int, dec, string
            Console.WriteLine(Class1.Op1(e.ClassInt));

            Console.WriteLine(Class1.Op1(e.ClassDecimal));

            Console.WriteLine(Class1.Op1(e.ClassString));
            Console.ReadLine();
        }
    }
}

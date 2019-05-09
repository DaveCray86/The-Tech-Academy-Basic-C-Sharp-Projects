using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page115_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number: ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can choose another number if you like: ");
            string s = Console.ReadLine();

            var Test1 = Class1.action1(44);
            var Test2 = Class1.action1(6, 13);

            Console.WriteLine(Test1);
            Console.WriteLine(Test2);
            Console.ReadLine();
        }
    }
}

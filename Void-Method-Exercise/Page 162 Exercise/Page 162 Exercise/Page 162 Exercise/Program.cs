using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_162_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //const variable
            const string name = "Jon";
            Console.WriteLine("Hi, my name is {0}", name);

            //using 'var'
            var names = new List<string>() { "Jon", "Cole", "Steve", "Iren" };
            Console.WriteLine(names[0]);

            //chaining constructors
            Name1 x = new Name1("Jon");

            Console.ReadLine();
        }
    }
}

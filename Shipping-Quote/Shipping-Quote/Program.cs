using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Planet Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight: ");
            int pWeight = Convert.ToInt32(Console.ReadLine());

            int weight = 50;
            if (pWeight > weight)
            {
                Console.WriteLine("Your package is too heavy to be shipped via Planet Express.Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else if (pWeight <= weight)
            {
                Console.ReadLine();
            }

            Console.WriteLine("Please enter the package width: ");
            int pWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int pHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            int pLength = Convert.ToInt32(Console.ReadLine());

            if (pWidth + pHeight + pLength > 50)
            {
                Console.WriteLine("Your package is too large to be shipped by Planet Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else if (pWidth + pHeight + pLength < 50)
            {
                int total = pWidth + pHeight + pLength * pWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00");
            }
            Console.ReadLine();
        }
    }
}

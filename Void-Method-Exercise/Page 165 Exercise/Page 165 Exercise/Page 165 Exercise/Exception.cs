using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_165_Exercise
{
    public class FormatException : Exception
    {
        public FormatException()
        {
            Console.WriteLine("That is not a valid age.");
            Console.ReadLine();
            return;
        }
    }

    public class ZeroException : Exception
    {
        public ZeroException()
        {
            Console.WriteLine("You cannot input a 0 for your age.");
            return;
        }
    }

    public class NegException : Exception
    {
        public NegException()
        {
            Console.WriteLine("You cannot enter a negative numebr as an age.");
            Console.ReadLine();
            return;
        }
    }
}

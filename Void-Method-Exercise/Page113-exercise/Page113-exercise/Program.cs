using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page113_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the real world...");
            New1 x = new New1();
            x.Operation(x);

            New1 y = new New1(7, 8);

            New1.Operation(3, 4);

            New1 state2 = new New1(3, 6);
        }
    }
}

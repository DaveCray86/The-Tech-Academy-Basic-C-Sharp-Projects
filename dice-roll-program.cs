using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice-roll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numGen = new Random();

                        int num1 = 0;
                        int num2 = 0;

                        while (num2 != 6)
                        {
                            num2 = numGen.Next(1, 7);
                            Console.WriteLine("You rolled: " + num2 + ".");
                            num1++;
                        }
                        Console.WriteLine("You spent " + num1 + " rolls, to roll a 6.");
                        Console.ReadKey();
        }
    }
}
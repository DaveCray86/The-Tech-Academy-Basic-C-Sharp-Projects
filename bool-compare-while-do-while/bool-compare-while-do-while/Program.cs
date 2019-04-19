using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool_compare_while_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number am I thinking of? Guess between 1 and 100.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Wrong number, try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Not too far away, but try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. Try again please.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 99:
                        Console.WriteLine("You guessed 99. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 44:
                        Console.WriteLine("You guessed 44. Good job, here's a cookie.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Wrong answer try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.ReadLine();
        }
    }
}

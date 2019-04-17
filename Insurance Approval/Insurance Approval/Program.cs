using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI charge? Enter True or False: ");
            string answer = Console.ReadLine().ToLower();
            bool answer1 = Convert.ToBoolean(answer);

            Console.WriteLine("How many speeding tickets do you have?: ");
            int speedTick = Convert.ToInt32(Console.ReadLine());

            if (age >= 15 && answer1 == false && speedTick <= 3)
            {
                Console.WriteLine("You are qualified.");
                Console.ReadLine();
            }
            else if (age >= 15 && answer1 == true && speedTick <= 3)
            {
                Console.WriteLine("You are not qualified.");
                Console.ReadLine();
            }
            else if (age < 15 || answer1 == false || speedTick > 3)
            {
                Console.WriteLine("You are not qualified.");
                Console.ReadLine();
            }
            else if (age < 15 || answer1 == true || speedTick > 3)
            {
                Console.WriteLine("You are not qualifed.");
                Console.ReadLine();
            }
            else if (age >= 15 && answer1 == false && speedTick < 3)
            {
                Console.WriteLine("You are not qualified.");
                Console.ReadLine();
            }
        }
    }
}

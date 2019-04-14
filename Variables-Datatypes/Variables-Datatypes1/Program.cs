using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Datatypes1
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a starter program, comment. Ctrl+k+c with line highlited to comment and Ctrl+k+u to uncomment
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is " + yourName);
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            Console.WriteLine("Your favorite number is: " + favoriteNumber);
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favoriteNum = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();

            // Different data types.

            bool isStudying = false;
            byte hoursWorked = 60;
            sbyte currentTemp = -45;
            char randomLetter = 'X';
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 255.9168161;
            float secondsLeft = 5.26f;
            short tempOnMars = -235;
            string myName = "David";

            Console.WriteLine(questionMark);
            Console.ReadLine();

            int currentAge = 33;
            string yearsOld = currentAge.ToString(); //Convert int to string.

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
        }
    }
}

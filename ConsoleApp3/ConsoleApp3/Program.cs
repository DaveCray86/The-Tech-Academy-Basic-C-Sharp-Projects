using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes an input from the user, multiplies it by 50, and prints the result to the console. 
            Console.WriteLine("Please enter a number to multiply by 50: ");
            string inputNum1 = Console.ReadLine();
            int inputNumber1 = Convert.ToInt32(inputNum1);
            int total1 = inputNumber1 * 50;
            Console.WriteLine(total1);
            Console.ReadLine();

            // Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Please enter another number to add to 25 : ");
            string inputNum2 = Console.ReadLine();
            int inputNumber2 = Convert.ToInt32(inputNum2);
            int total2 = inputNumber2 + 25;
            Console.WriteLine(total2);
            Console.ReadLine();

            // Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Please enter another number to divide by 12.5: ");
            string inputNum3 = Console.ReadLine();
            int inputNumber3 = Convert.ToInt32(inputNum3);
            double total3 = inputNumber3 / 12.5;
            Console.WriteLine(total3);
            Console.ReadLine();

            // Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("Please enter a number to see if it is greater than 50: ");
            string myNum = Console.ReadLine();
            int myNum1 = Convert.ToInt32(myNum);
            int othNum = 50;
            bool answer = myNum1 >= othNum;
            Console.WriteLine(answer);
            Console.ReadLine();

            //Takes an input from the user, divides it by 7, and prints the remainder to the console 
            //(tip: think % operator).Takes an input from the user, divides it by 7, and prints the remainder 
            //to the console (tip: think % operator).
            Console.WriteLine("Enter a number to divide by 7: ");
            string inputNum5 = Console.ReadLine();
            int myNum5 = Convert.ToInt32(inputNum5);
            int quotient = 7;
            int answer2 = myNum5 % quotient;
            Console.WriteLine(answer2);
            Console.ReadLine();
        }
    }
}

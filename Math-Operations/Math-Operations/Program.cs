using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus ten = " + total.ToString());
            Console.WriteLine(combined);
            Console.ReadLine();

            //Subtraction
            int difference = 10 - 5;
            Console.WriteLine("Ten minus five = " + difference.ToString());
            Console.ReadLine();

            //Multiplication
            int product = 10 * 5;
            Console.WriteLine("Ten multiplied by five = " + product);
            Console.ReadLine();

            //Division
            int quotient = 50 / 5;
            Console.WriteLine(" Fifty divided by five = " + quotient);
            Console.ReadLine();

            //Exact integer w/ decimal.
            Double quotients = 100.0 / 17.0;
            Console.WriteLine(quotients);
            Console.ReadLine();

            //Remainder//
            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            //Comparison Operator. Below = true
            bool trueOrFalse = 12 > 5; // Because of denotion of > symbol.
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            bool trueFalse = 12 < 5; // False because of denotion of < symbol.
            Console.Write(trueFalse.ToString());
            Console.ReadLine();

            //Comparison Operator.
            int roomTemp = 70;
            int currentTemp = 68;
            //bool isCold = currentTemp <= roomTemp;
            bool isCold = currentTemp != roomTemp; // ! expression is used to switch to the opposite answer.
            Console.WriteLine(isCold);
            Console.ReadLine();


        }
    }
}

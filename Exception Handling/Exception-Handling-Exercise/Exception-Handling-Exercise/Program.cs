using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
            //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            List<int> testScores = new List<int>() { 85, 68, 99, 88, 75, 78, 84, 73, 84, 97 };

            Console.WriteLine("I have a list of numbers. Please enter a number to divide my numbers by: ");
            int div1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked " + div1);
            Console.ReadLine();
            while (guess != secWord)
            {
                Console.WriteLine("Enter a guess: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine("You Win!");
            Console.ReadLine();



            //2. Run that code, entering in non-zero numbers as the user. Look at the displayed results.



            //3. Run that code, entering in zero as the number to divide by. Note any error messages you get.



            //4. Run that code, entering in a string as the number to divide by. Note any error messages you get.



            //5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program display a message 
            //to the display to let you know the program has emerged from the try/catch block and continued on with program execution. 
            //In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. 
            //Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            try
            {
                catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.ReadLine();
            }
        }
    }
}

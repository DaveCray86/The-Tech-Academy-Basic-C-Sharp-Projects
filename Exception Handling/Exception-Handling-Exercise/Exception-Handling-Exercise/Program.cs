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

            try
            {
                List<int> testScores = new List<int>();
                testScores.Add(85);
                testScores.Add(68);
                testScores.Add(99);
                testScores.Add(88);
                testScores.Add(75);
                testScores.Add(78);
                testScores.Add(84);
                testScores.Add(73);
                testScores.Add(97);

                Console.WriteLine("Please enter a number to divide by: ");
                int input = Convert.ToInt32(Console.ReadLine());

                foreach (int score in testScores)
                {
                    Console.WriteLine(score / input);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Remember you cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
            

            //2. Run that code, entering in non-zero numbers as the user. Look at the displayed results.



            //3. Run that code, entering in zero as the number to divide by. Note any error messages you get.

            //System cannot divide by 0.


            //4. Run that code, entering in a string as the number to divide by. Note any error messages you get.



            //5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program display a message 
            //to the display to let you know the program has emerged from the try/catch block and continued on with program execution. 
            //In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. 
            //Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            
        }   
    }
}

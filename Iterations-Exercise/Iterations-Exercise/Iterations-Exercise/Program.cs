using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one - dimensional Array of strings. 
            //Ask the user to input some text. 
            //Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //Then create a loop that prints off each string in the Array on a separate line.
            string[] badPasswords = { "123456", "password", "123456789", "12345678", "12345", "111111",
                                      "1234567", "sunshine", "qwerty", "iloveyou", "princess", "admin", "Admin",
                                      "Password", "welcome", "4444", "abc123", "123123", "!@#$%^&*" , "donald"};

            Console.WriteLine("Please enter a random word: ");
            var words1 = (Console.ReadLine());
            var total = badPasswords + words1;
            Console.WriteLine(Console.ReadLine());
            
            foreach (string badPasswords in words1)
            {
                Console.WriteLine(badPasswords[] + words1);
                words1++;
            }
            Console.ReadLine();

            //2. Create an infinite loop.
            int index = 1;
            while (index <= 10)
            {
                Console.WriteLine(index);
                //index++;
            }
            Console.ReadLine();

            //3.Fix the infinite loop so it will execute.
            int index = 1;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();

            //4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            int index = 1;
            while (index < 10)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            int index = 1;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();

            //6.Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            List<string> names = new List<string>();
            names.Add("Curtis");
            names.Add("Dave");
            names.Add("Misty");
            names.Add("Adolfo");
            names.Add("Kevin");
            names.Add("Corey");
            names.Add("Guillermo");
            names.Add("Steven");
            names.Add("Eva");

            Console.WriteLine("Please search for the name starting with the letter M: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (input = 0; input < names.Length; input++)
            {
                if (names[input] == "Misty")
                {
                    Console.WriteLine(names[input]);
                }
            }
            Console.ReadLine();

            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            for (input = 0; input < names.Length; input++)
            {
                if (names[input] != "Misty")
                {
                    Console.WriteLine("This name does not exist." + [input]);
                }
            }
            Console.ReadLine();

            //8. Add code to that above loop that stops it from executing once a match has been found.
            for (input = 0; input < names.Length; input++)
            {
                if (names[input] == "Misty")
                {
                    Console.WriteLine("Thank you for finding the match: " + input);
                }
                else
                {
                    Console.WriteLine(input + " does not exist on my list.");
                }
            }
            Console.ReadLine();

            //9. Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List. Create a loop that iterates through the list and then 
            //displays the indices of the array that contain matching text on the screen.
            List<string> names12 = new List<string> { "Curtis", "Dave", "Misty", "Adolfo", "Kevin", "Corey", "Guillermo", "Steven", "Eva", "Misty" };

            Console.WriteLine("Please search for the name starting with the letter Misty: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (input = 0; input < names.Length; input++)
            {
                while (names[input] == "Misty")
                {
                    Console.WriteLine("This input already exists in the database: " + input);
                }
            }
            Console.ReadLine();

            //10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            for (input = 0; input < names.Length; input++)
            {
                while (input != names)
                {
                    Console.WriteLine(input + " Does not exist in the list.");
                }
            }
            Console.ReadLine();

            //11. Create a List of strings that has at least two identical strings in the List. 
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and 
            //whether or not it has already appeared in the list.
            List<int> randomNums = new List<int> { 25, 54, 10, 98, 44, 17, 10, 55, 78, 37, 33, 33, 48, 92, 85, 68, 88 };

            Console.WriteLine("Please enter a number between 1 and 100: ");
            int input = Convert.ToInt32(Console.ReadLine());

            foreach (int num in randomNums)
            {
                if (input = num)
                {
                    Console.WriteLine("The following numbers exist more than once: " + num);
                }
            }
            Console.ReadLine();
        }
    }
}

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
            Console.WriteLine("Please add to my bad password list. Please input a bad password: ");
            string input = Console.ReadLine();

            foreach (string result in badPasswords)
            {
               Console.WriteLine(result + input);
            }
            Console.ReadLine();

            //2. Create an infinite loop.
            int index = 1;
            while (index <= 10)
            {
               Console.WriteLine(index);
            }
            Console.ReadLine();

            //3.Fix the infinite loop so it will execute.
            int index1 = 1;
            while (index1 <= 10)
            {
               Console.WriteLine(index1);
               index1++;
            }
            Console.ReadLine();

            //4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            int index2 = 1;
            while (index2 < 10)
            {
               Console.WriteLine(index2);
               index2++;
            }
            Console.ReadLine();

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            int index3 = 1;
            while (index3 <= 10)
            {
               Console.WriteLine(index3);
               index3++;
            }
            Console.ReadLine();

            //6.Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List.
            Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.

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

            Console.WriteLine("Please type a name from the provided list: ");
            string input7 = Console.ReadLine();

            int index = names.FindIndex(s => s == input7);
            for (int i = 0; i < names.Count; i++)
            {
               if (input7.Contains(names[i]))
               {
                   Console.WriteLine(names[i] + index + " is in my list of names. ");
               }
            }
            Console.ReadLine();

            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            List<string> names1 = new List<string>();
            names1.Add("Curtis");
            names1.Add("Dave");
            names1.Add("Misty");
            names1.Add("Adolfo");
            names1.Add("Kevin");
            names1.Add("Corey");
            names1.Add("Guillermo");
            names1.Add("Steven");
            names1.Add("Eva");

            Console.WriteLine("Please search for the name Kevin: ");
            string input1 = Console.ReadLine();

            for (int j = 0; j < names1.Count; j++)
            {
               if (input1 != names1[j])
               {
                   Console.WriteLine(input1 + " does not exist.");
                   break;
               }
               else if (input1.Contains(names1[j]))
               {
                   Console.WriteLine("The name " + input1 + " is on my list.");
                   break;
               }
            }
            Console.ReadLine();

            //8. Add code to that above loop that stops it from executing once a match has been found.
            List<string> names2 = new List<string>();
            names2.Add("Curtis");
            names2.Add("Dave");
            names2.Add("Misty");
            names2.Add("Adolfo");
            names2.Add("Kevin");
            names2.Add("Corey");
            names2.Add("Guillermo");
            names2.Add("Steven");
            names2.Add("Eva");

            Console.WriteLine("Please type a name from the provided list: ");
            string input2 = Console.ReadLine();

            for (int k = 0; k < names2.Count; k++)
            {
               if (input2.Contains(names2[k]))
               {
                   Console.WriteLine(names2[k] + " is in my list of names. ");
                   break;
               }
            }
            Console.ReadLine();

            //9. Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List. Create a loop that iterates through the list and then
            //displays the indices of the array that contain matching text on the screen.
            List<string> names12 = new List<string> { "Curtis", "Dave", "Misty", "Adolfo", "Kevin", "Corey", "Guillermo", "Steven", "Eva", "Dave" };
            Console.WriteLine("Please search for a name on my list: ");
            string input3 = Console.ReadLine();

            for (int k = 0; k < names12.Count; k++)
            {
               if (names12[k] == input3)
               {
                   Console.WriteLine(input3 + k);
               }
            }
            Console.ReadLine();

            //10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            List<string> names12 = new List<string> { "Curtis", "Dave", "Misty", "Adolfo", "Kevin", "Corey", "Guillermo", "Steven", "Eva", "Dave" };
            Console.WriteLine("Please search for a name on my list: ");
            string input3 = Console.ReadLine();

            for (int k = 0; k < names12.Count; k++)
            {
               if (names12[k] == input3)
               {
                   Console.WriteLine(input3 + k);
               }
               else if (input3 != names12[k])
               {
                   Console.WriteLine(input3 + " Does not match my list.");
                   break;
               }
            }
            Console.ReadLine();

            //11. Create a List of strings that has at least two identical strings in the List. 
            Create a foreach loop that evaluates each item in the list, and displays a message showing the string and
            whether or not it has already appeared in the list.

            List<string> x = new List<string>() { "Curtis", "Dave", "Misty", "Adolfo", "Kevin", "Corey", "Guillermo", "Steven", "Eva", "Dave" };

            foreach(string s in x)
            {
               foreach(string l in x)
               {
                   if ((s == l) && (x.IndexOf(s) != x.LastIndexOf(l)) && ((x.IndexOf(s) < x.LastIndexOf(l))))
                   {
                       Console.WriteLine(s + " is on the list multiple times. ");
                   }
               }
            }

            IEnumerable<string> y = x.AsQueryable().Distinct();

            List<string> n = y.ToList();

            var duplicates = n
            .GroupBy(b => b)
            .Where(g => g.Skip(1).Any())
            .SelectMany(g => g);

            foreach (string s in n)
            {
               if (n != y)
               {
                   Console.WriteLine("These are the names contained within my list: " + s);
               }
               else
               {
                   Console.WriteLine("You have failed... ");
               }
            }
            Console.ReadLine();
            
        }
    }
}

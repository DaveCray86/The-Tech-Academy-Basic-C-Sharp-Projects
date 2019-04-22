using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Exercise
{
    class Program
    {
        static void Main()
        {
            //Array of Strings. Ask the user to select an index of the Array and then display the string at that index on the screen:
            string[] badPasswords = { "123456", "password", "123456789", "12345678", "12345", "111111",
                                      "1234567", "sunshine", "qwerty", "iloveyou", "princess", "admin", "Admin",
                                      "Password", "welcome", "4444", "abc123", "123123", "!@#$%^&*" , "donald"};

            Console.WriteLine("Welcome to top 20 worst passwords. \nPlease select a number between 0 and 19.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(badPasswords[input]);

            //Add in a message that displays when the user selects an index that doesn’t exist.
            if (input <= 19)
                Console.WriteLine("The index you entered is bad password " + input);
            else
                Console.WriteLine(input + " does not exist on my list.");
            Console.ReadLine();


            //Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen:            
            int[] numArray = { 616, 702, 808, 319, 214, 215, 408, 555, 302, 123 };
            Console.WriteLine("Select a number between 0 and 9: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numArray[input1]);
            Console.ReadLine();

            //Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen:
            List<string> passList = new List<string>();    
            passList.Add("123456");                         
            passList.Add("password");
            passList.Add("123456789");
            passList.Add("12345678");
            passList.Add("12345");
            passList.Add("111111");
            passList.Add("1234567");
            passList.Add("sunshine");
            passList.Add("qwerty");
            passList.Add("iloveyou");
            passList.Add("princess");
            passList.Add("admin");
            passList.Add("Admin");
            passList.Add("Password");
            passList.Add("welcome");
            passList.Add("4444");
            passList.Add("abc123");
            passList.Add("123123");
            passList.Add("!@#$%^&*");
            passList.Add("donald");

            Console.WriteLine("Pick another number between 0 and 19: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(passList[input2]);
            Console.ReadLine();
        }
    }
}

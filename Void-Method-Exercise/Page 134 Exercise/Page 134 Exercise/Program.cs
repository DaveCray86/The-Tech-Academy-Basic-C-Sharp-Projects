using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_134_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //console color change
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            //sleep loop
            bool sleep = false;
            while (sleep == false)
            {
                Console.WriteLine("Please enter the current day of the week: ");
                //try catch start
                try
                {
                    string read = Console.ReadLine();
                    
                    bool res = int.TryParse(read, out int num1);
                    if (res == false)
                    {
                        DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), read);
                        Console.WriteLine("It's " + day + "! ");
                        sleep = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a legitimate day of the week.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a legitimate day of the week.");
                }
                //end try catch
            }
            //end sleep
            Console.WriteLine("Press enter to end the program.");
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

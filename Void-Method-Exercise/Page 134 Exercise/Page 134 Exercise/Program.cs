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
            Console.WriteLine("Please enter the current day of the week:");
            try
            {
                string currentDay = Console.ReadLine();
                Week_Days.DaysOfTheWeek day = (Week_Days.DaysOfTheWeek)Enum.Parse(typeof(Week_Days.DaysOfTheWeek), currentDay);

                Console.WriteLine("The day is {0}.", day);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        } 
    }
}

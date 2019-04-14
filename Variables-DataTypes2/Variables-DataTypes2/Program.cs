using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool needHelp = false;
            string helpStatus = Convert.ToString(needHelp);
            Console.WriteLine(helpStatus);
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share ? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyToday = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(studyToday);
            int total = hoursStudied;
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

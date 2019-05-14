using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_156_Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine("The current date and time is:{0}", current);
            Console.WriteLine("Please input a number: ");
            int user = Convert.ToInt32(Console.ReadLine());
            DateTime later = current.AddHours(user);
            Console.WriteLine("It will be {0} in " + user + " Hours from now. ", later);
            Console.ReadLine();
        }
    }
}

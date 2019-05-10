using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_126_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Interface1 quittable = new Employee();
            employee.FirstName = "Rick";
            employee.LastName = "Sanchez";

            employee.SayName();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}

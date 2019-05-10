using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_129_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //List<Employee> employeeList = new List<Employee>();

            List<Employee> employeeList = new List<Employee>()
            {
                new Employee{ FirstName = "Mark", LastName = "Wahlberg", callerID = 001},
                new Employee { FirstName = "Tom", LastName = "Sellick", callerID = 005 },
                new Employee {  FirstName = "Darth", LastName = "Vader", callerID = 006 },
                new Employee {  FirstName = "James", LastName = "Bond", callerID = 007 },

            };

            List<Employee> employeeList2 = new List<Employee>()
            {
                new Employee{ FirstName = "Mark", LastName = "Wahlberg", callerID = 001},
                new Employee { FirstName = "Tom", LastName = "Sellick", callerID = 005 },
                new Employee {  FirstName = "Darth", LastName = "Vader", callerID = 006 },
                new Employee {  FirstName = "James", LastName = "Bond", callerID = 007 },

            };

            Console.WriteLine("List of employees:");

            foreach (Employee worker in employeeList)
            {
                worker.SayName();
                //Console.WriteLine(employee);

            }

            Console.WriteLine("\nUsing 2 lists and 2 foreach loops the employees will now be compared using the overloaded operator '==' to determine \nif any caller IDs are matching");
            foreach (Employee e1 in employeeList)
            {
                foreach (Employee e2 in employeeList2)
                {
                    bool compare = e1 == e2;
                    if (e1.FirstName == e2.FirstName)
                    {
                        continue;
                    }
                    else if (compare)
                    {
                        Console.WriteLine(e1.FirstName + " And " + e2.FirstName + " have the same caller ID.");
                    }
                    else
                    {
                        continue;
                        //Console.WriteLine(e1.FirstName + " And " + e2.FirstName + " are NOT the same.");
                    }
                }
            }
            Console.WriteLine("\nPress enter to quit.");
            Console.ReadLine();
        }
    }
}

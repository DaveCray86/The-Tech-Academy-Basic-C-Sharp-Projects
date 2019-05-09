using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page124_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.fName = "Sample";
            employee.lName = "Student";
            employee.callID = 44;                           //ID number.
            employee.SayName();                             //Superclass call.
            Console.WriteLine(employee.callID);
            Console.ReadLine();
        }
    }
}

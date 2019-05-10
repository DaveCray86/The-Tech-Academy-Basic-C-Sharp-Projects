using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_129_Exercise
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int callerID { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + callerID);
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool isIt = employee1.callerID == employee2.callerID;
            return isIt;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool isItNot = employee1.callerID != employee2.callerID;
            return isItNot;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_120_Exercise
{
    public class Employee : Person
    {
        public int callID { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + fName + " " + lName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_129_Exercise
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int callerID { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + callerID);

        }
    }
}

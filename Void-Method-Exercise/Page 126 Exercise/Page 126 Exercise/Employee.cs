using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_126_Exercise
{
    public class Employee : Person, Interface1
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Smartest man in this dimension.");
            Console.WriteLine("\nPress enter to quit.");
        }
    }
}

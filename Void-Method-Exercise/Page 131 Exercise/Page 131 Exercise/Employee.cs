using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_131_Exercise
{
    class Employee<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<T> things { get; set; }
        public void SayName()
        {
            Console.WriteLine("\nName: " + FirstName + " " + LastName);
        }
        public void copy()
        {
            Console.WriteLine("\nList: ");
            for (int i = 0; i < things.Count; i++)
                Console.WriteLine(things[i]);
        }
    }
}

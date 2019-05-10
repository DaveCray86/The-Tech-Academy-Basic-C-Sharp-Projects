using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_131_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeString = new Employee<string>();
            employeeString.FirstName = "String";
            employeeString.LastName = "Generics";
            employeeString.things = new List<string>();
            employeeString.things.Add("Yo, ");
            employeeString.things.Add("this");
            employeeString.things.Add("is");
            employeeString.things.Add("a");
            employeeString.things.Add("string");
            employeeString.things.Add("list");
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.FirstName = "Int";
            employeeInt.LastName = "Generics";
            employeeInt.things = new List<int>();
            employeeInt.things.Add(1);
            employeeInt.things.Add(1);
            employeeInt.things.Add(2);
            employeeInt.things.Add(1);
            employeeInt.things.Add(1);
            employeeInt.things.Add(2);
            employeeInt.things.Add(3);
            employeeInt.things.Add(2);
            employeeInt.things.Add(1);
            employeeString.SayName();
            employeeString.copy();
            employeeInt.SayName();
            employeeInt.copy();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_140_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> employees = new List<employee>();

            employees.Add(new employee { fname = "Joe", lname = "Shmoe", eID = 1, age = 35 });
            employees.Add(new employee { fname = "Luke", lname = "Skywalker", eID = 2, age = 21 });
            employees.Add(new employee { fname = "Darth", lname = "Vader", eID = 3, age = 54});
            employees.Add(new employee { fname = "Robin", lname = "Hood", eID = 4, age = 33 });
            employees.Add(new employee { fname = "Princess", lname = "Peach", eID = 5, age = 22 });
            employees.Add(new employee { fname = "Super", lname = "Mario", eID = 6, age = 31 });
            employees.Add(new employee { fname = "Samus", lname = "Aran", eID = 7, age = 26});
            employees.Add(new employee { fname = "Joe", lname = "Snow", eID = 8, age = 27 });
            employees.Add(new employee { fname = "Arya", lname = "Stark", eID = 9, age = 18 });
            employees.Add(new employee { fname = "Ramsey", lname = "Bolton", eID = 10, age = 23 });

            foreach (employee joeName in employees)
            {
                if (joeName.fname == "Joe")                                             //Foreach name 'Joe' do this.
                {
                    List<string> nameJoe = new List<string>();                          //New list created to print name from.
                    nameJoe.Add(joeName.fname + " " + joeName.lname);                   //Adding name to new list.
                    Console.WriteLine(joeName.fname + " " + joeName.lname);
                }
            }

            List<employee> Joes = employees.Where(x => x.fname == "Joe").ToList();      //List all employees named 'Joe'
            foreach (employee Joe in Joes)
            {
                Console.WriteLine(Joe.fname + " " + Joe.lname);
            }

            List<employee> idNo = employees.Where(x => x.eID > 5).ToList();             //List all employees with id number higher than 5.
            foreach (employee eID in idNo)
            {
                Console.WriteLine(eID.fname + " " + eID.lname + " " + eID.eID);
            }

            List<employee> old = employees.Where(x => x.age > 32).ToList();             //List all employees older than 32 with id number and first/last name.
            foreach (employee age in old)
            {
                Console.WriteLine(" \n" + age.fname + " " + age.lname + "\n" + "employee identification: " + age.eID + " " + "\n" + "employee age: " + age.age);
            }
            Console.ReadLine();
        }
    }
}

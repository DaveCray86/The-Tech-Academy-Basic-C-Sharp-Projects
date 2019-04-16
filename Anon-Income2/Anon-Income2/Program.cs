using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon_Income2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1, please enter your hourly rate: ");
            Console.ReadLine();
            int p1Hr = Convert.ToInt32(Console.Read());

            Console.WriteLine("Person 1, please enter your hours worked for the week: ");
            Console.ReadLine();
            int p1Hw = Convert.ToInt32(Console.Read());

            Console.WriteLine("Person 2, please enter your hourly rate: ");
            Console.ReadLine();
            int p2Hr = Convert.ToInt32(Console.Read());

            Console.WriteLine("Person 2, please enter your hours worked for the week: ");
            Console.ReadLine();
            int p2Hw = Convert.ToInt32(Console.Read());

            Console.WriteLine("Weekly Salary of Person 1: ");
            Console.ReadLine();
            int per1Sal = p1Hr * p1Hw;
            Console.Write(per1Sal);
            Console.ReadLine();

            Console.WriteLine("Weekly Salary of Person 2: ");
            Console.ReadLine();
            int per2Sal = p2Hr * p2Hw;
            Console.Write(per2Sal);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = per1Sal > per2Sal; 
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_165_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0) throw new ZeroException();
                if (age < 0) throw new NegException();

                Console.WriteLine("You were born in year {0}.", 2019 - age);
                Console.ReadLine();
            }
            catch (ZeroException) { }
            catch (NegException) { }
            catch (Exception other)
            {
                Console.WriteLine("That is not a valid age.", other);
                Console.ReadLine();
                return;
            }
        }
    }
}

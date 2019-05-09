using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page115_Exercise
{
    class Class1
    {
        public static int action1(int firstInt, int secondInt = 0, string str = "")
        {
            firstInt = firstInt * 18 + 8;
            secondInt = secondInt - 2 * 8;
            int i = firstInt + secondInt;

            return i;
        }
        public static void inputChoice()
        {
            int Test3 = 0;
            int t2;
            
            int t1 = Convert.ToInt32(Console.ReadLine());
            
            string a = Console.ReadLine();
            if (a == "")
            {
                Test3 = Class1.action1(t1);
            }
            else
            {
                t2 = Convert.ToInt32(a);
                Test3 = Class1.action1(t1, t2);
            }
            Console.WriteLine(Test3);
            Console.ReadLine();
        }
    }
}

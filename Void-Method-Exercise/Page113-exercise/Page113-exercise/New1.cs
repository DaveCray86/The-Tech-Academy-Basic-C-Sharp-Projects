using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page113_exercise
{
    public class New1
    {
        public int a { get; set; }
        public int b { get; set; }

        public New1()
        {
            a = 0;
            b = 0;

        }
        public New1(int A, int B)
        {
            a = A;
            b = B;

        }
        public static void Operation(int x, int y)
        {
            x = x * 13;
            Console.WriteLine(y);
            Console.ReadLine();
        }
        public void Operation(New1 s)
        {
            s.a = s.a * 13;
            Console.WriteLine(s.b);
            Console.ReadLine();
        }
    }
}

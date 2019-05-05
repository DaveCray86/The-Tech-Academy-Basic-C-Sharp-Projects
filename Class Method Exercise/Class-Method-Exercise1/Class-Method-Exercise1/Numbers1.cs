using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Exercise1
{
    class Numbers1
    {
        public int a { get; set; }
        public int b { get; set; }

        public Numbers1()
        {
            a = 0;
            b = 0;
        }
        public Numbers1(int A, int B)
        {
            a = A;
            b = B;
        }
        public void setA(int x)
        {
            a = x;
        }
        public void setB(int x)
        {
            b = x;
        }
        public int Add()            //Addition Method.
        {
            int Add = a + b;
            return Add;
        }
        public int Mult()          //Multiplication Method.
        {
            int Mult = a * b;
            return Mult;
        }
        public int Sub()          //Subtraction Method.
        {
            int Sub = a - b;
            return Sub;
        }
        public int Divide()       //Division Method.
        {
            int Divide = a / b;
            return Divide;
        }
        public void print()
        {
            Console.WriteLine("A = " + a + " B = " + b);
        }
    }
}

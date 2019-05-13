using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);
            using (StreamWriter file = new StreamWriter(@"C:\Users\David\Log\log.txt", true))
            {
                file.WriteLine(num1);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\David\Log\log.txt"));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page117_Exercise
{
    class Class1
    {
        int x { get; set; }

        public Class1()
        {
            x = 0;
        }
        public Class1(int i)
        {
            x = i;
        }
        public int getX(Class1 e)
        {
            return x;
        }
        public void multiplyByTwo(int x)
        {
            x = x * 2;

        }
        public void multiplyByTwo(Class1 e)
        {
            e.x = e.x * 2;
        }
        public void div(int x)
        {
            x = x / 2;
        }
        public void div(Class1 e)
        {
            e.x = e.x / 2;
        }



        //Static Class
        public static class TempConvert
        {
            public static double CelsiusToFahrenheit(string tempC)
            {
                // Convert argument to double for calculations.
                double celsius = Double.Parse(tempC);

                // Convert Celsius to Fahrenheit.
                double fahrenheit = (celsius * 9 / 5) + 32;

                return fahrenheit;
            }

            public static double FahrenheitToCelsius(string tempF)
            {
                // Convert argument to double for calculations.
                double fahrenheit = Double.Parse(tempF);

                // Convert Fahrenheit to Celsius.
                double celsius = (fahrenheit - 32) * 5 / 9;

                return celsius;
            }
        }
    }
}

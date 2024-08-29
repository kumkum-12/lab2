using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q2
    {
        public static void q2()
        {
            Console.Write("Enter temperature in Celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal fahrenheit = (celsius * 9 / 5) + 32;

            if (celsius < 0)
            {
                Console.WriteLine("Warning: Freezing temperatures!");
            }

            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }
    }
}

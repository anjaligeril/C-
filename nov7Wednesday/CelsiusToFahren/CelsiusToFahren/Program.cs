using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahren
{
    class Program
    {
        static void Main(string[] args)
        {
            const int orginalCelsius = 32;
            int celsius =Convert.ToInt32 (Console.ReadLine());
            double result = celsius * 1.8 + orginalCelsius;
            Console.WriteLine("The temerature in celsius is {0} and temperature in Fahrenheit {1:f2}",celsius,result);
            Console.ReadKey();

        
        }
    }
}

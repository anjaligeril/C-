using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num,result;
            char unit;
            Console.WriteLine("Enter the temperature");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the unit \t c or f");
            unit = Convert.ToChar(Console.ReadLine());

            if (unit == 'c'|| unit == 'C')
            {
                result = (num * 1.8) + 32;
                Console.WriteLine("The result in fahrenheit {0} ", result);
            }
            else if (unit == 'f'|| unit == 'F')
            {
                result = (num - 32) / 1.8;
                Console.WriteLine("The result in celsius {0} ", result);
            }
            else
            {
                Console.WriteLine("enter valid input");
            }
            Console.ReadKey();
            
        }
    }
}

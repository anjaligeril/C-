using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larger
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the two number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Larger is{0} ",a);
            }else if (a < b)
            {
                Console.WriteLine("Larger is{0} ", b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are same", a,b);
            }

            Console.ReadKey();
        }
    }
}

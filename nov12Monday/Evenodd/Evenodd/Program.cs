using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());


            var result=(num % 2 == 0)? "even" : "odd";
            Console.WriteLine(result);
           Console.ReadKey();
        }
    }
}

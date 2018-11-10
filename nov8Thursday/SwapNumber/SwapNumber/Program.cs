using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the numbers to be swapped");
             a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
           // a = 10;
          //  b = 20;
            swapNumbers(ref a, ref b);
            Console.WriteLine("The swapped Values are\n {0} \n {1}", a, b);
            Console.ReadKey();
        }

        static void swapNumbers(ref int a,ref int b)
        {
            int temp=0;
            temp = a;
            a = b;
            b = temp;
        }
    }
}

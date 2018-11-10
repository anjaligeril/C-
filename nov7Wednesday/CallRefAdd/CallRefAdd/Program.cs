using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallRefAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;
            Console.WriteLine("Enter the values of a and b");
            a =Convert.ToInt32 (Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            calculateTotal(a,  b, out  total);
            Console.WriteLine("The total is "+total);
            Console.ReadKey();
        }

        static void calculateTotal(int a,int b,out int total)
        {
            total = a + b;
        }
    }
}

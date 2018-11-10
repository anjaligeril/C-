using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(2, 3);
            Complex c3 = new Complex();
            c3 = c1 + c2;
            Console.WriteLine("the complex number is {0}+i{1}", c3.real, c3.imaginary);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbyReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int testValue = 1;
            Console.WriteLine("Original Value {0}", testValue);
            testCallByValue(testValue);
            Console.WriteLine("After calling testCallByValue  Value {0}", testValue);
           

            Console.WriteLine("\n");
            Console.WriteLine("Original Value {0}", testValue);
            testRef(ref testValue);
            Console.WriteLine("After calling testRef Value {0}", testValue);

            //call by reference using out
            Console.WriteLine("\n");
            int testValue2 = 120;
            Console.WriteLine("Original Value {0}", testValue2);
            testOut(out testValue2);
            Console.WriteLine("After Call testOut  Value {0}", testValue2);
            Console.ReadKey();
        }

        static void testCallByValue(int aValue)
        {
            aValue = 50;
            Console.WriteLine("Inside testCallByValue {0}", aValue);
        }

        static void testRef(ref int aValue)
        {
            aValue = 100;
            Console.WriteLine("Inside testRef {0}", aValue);
        }
        static void testOut(out int aValue)
        {
            aValue = 500;
            Console.WriteLine("Inside testRef {0}", aValue);
        }
    }
}

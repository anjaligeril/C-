using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public enum Days {Sun=10,Mon,Tues,Wed,Thurs,Fri,Sat};
    //public enum Days {Sun,Mon,Tues,Wed,Thurs,Fri,Sat};
    class Program
    {
        static void Main(string[] args)
        {
            int x =(int) Days.Mon;
            int y = (int)Days.Fri;
            int z = (int)Days.Sat;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            

            int count = 0;
            int result = 0;
            int fn = 10;
            count++;
            result = count++ * --fn + 100;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            perform("hello", 50);
            perform("hai");

            perform(b: 10, a: "qq");
            Console.ReadKey();
        }
        static void perform(String a,int b=20)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

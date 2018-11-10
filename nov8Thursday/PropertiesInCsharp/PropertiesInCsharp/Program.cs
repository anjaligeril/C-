using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstName = "sheethal";
            p.lastName = "thakar";

            Console.WriteLine(p.firstName + " " + p.lastName);

            Console.WriteLine("the full name is {0}",p.fullName);
            Console.ReadKey();
        }
    }
}

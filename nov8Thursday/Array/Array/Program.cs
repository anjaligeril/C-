using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   int[] a= { 2,3,4,5};
               int i = 0;
               foreach(int number in a)
               {
                   Console.WriteLine("x[{0}] ={1}",i++,number);
               }
               Console.WriteLine("length "+a.Length);
               Console.WriteLine("Rank " + a.Rank);
               //Console.WriteLine("max{0} " ,a.Max);
               Console.ReadKey();*/

            String[,] name = {
                                { "john","smith"},
                                {"mary","somny" },
                                { "george","bush"}
            };
            foreach (String name1 in name)
            {
                Console.WriteLine("{0}", name1);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           /* for(int i =5; i>0; i--)
            {
              /*  int j = i;
                while (j > 0)
                {
                    Console.Write("*");
                    j--;
                }*/
              /*  for(int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }*/

            for(int i = 1; i < 6; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n\n ");

            for (int i = 1; i < 6; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 5; i > 0; i--)
            {
               
               for(int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 6;
            for(int i = 1; i<6; i++)
            {
                for(int k = 0; k < j; k++)
                {
                    Console.Write(" ");
                }
                for(int l = i; l > 0; l--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
                j--;
            }
            Console.ReadKey();
        }
    }
}

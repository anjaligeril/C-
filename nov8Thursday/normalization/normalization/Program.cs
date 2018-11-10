using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace normalization
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 55;
            int y = 64;
            double newX, newY;
            bool val=normalizationNumber(x, y, out newX, out newY);
            if (val)
            {
                Console.WriteLine("the value of new x " + newX);
                Console.WriteLine("the value of new Y " + newY);
            }
            else
            {
                Console.WriteLine("please enter valid value");
            }
            Console.ReadKey();

        }
       static bool normalizationNumber(int x, int y, out double x1, out double y1)
        {
            x1 = 0;
            y1 = 0;
            if ((x < 1) || (x > 100))
            {
                return false;
            }
            if ((y < 1) || y > 100)
            {
                return false;
            }
            if (x > y)
            {
                x1 = x / (double)x;
                y1 = y / (double)x;
            }
            else
            {
                x1 = x / (double)y;
                y1 = y / (double)y;
            }
            return true;
        }
    }
}

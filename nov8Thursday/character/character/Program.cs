using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter the character");
            c =Convert.ToChar( Console.ReadLine());
            if (char.IsLower(c))
            {
                Console.WriteLine("the letter is lower case");
            }else if (char.IsUpper(c))
            {
                Console.WriteLine("the letter is upper case");
            }else if (char.IsNumber(c))
            {
                Console.WriteLine("the letter is number");
            }else if (char.IsDigit(c))
            {
                Console.WriteLine("the letter is digit");
            }else if (char.IsSymbol(c))
            {
                Console.WriteLine("the letter is symbol");
            }
            Console.ReadKey();
        }
    }
}

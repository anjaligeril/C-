using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            //min value and max value 
            /*  Console.WriteLine("min value of byte {0} and max value {1} ",byte.MinValue,byte.MaxValue);
               Console.WriteLine("min value of int {0} and max value {1} ",int.MinValue,int.MaxValue );
              Console.WriteLine("min value of char {0} and max value {1} ", char.MinValue, char.MaxValue);
              Console.WriteLine("min value of float {0} and max value {1} ", float.MinValue, float.MaxValue);*/


            //escape sequence

            //Console.WriteLine("\"Anjali Elizabeth Joseph\" \n 56,Leander Street\n Brampton\n L6S3M7\t4168223193");

            //Type conversion

            //implicit type conversion

            /*  byte b = 3;
              int a = b;
              Console.WriteLine(a);*/

            //explicit type conversion

            /*   float f1 = 3.2f;
               int a1 =(int) f1;*/

            //in compatible datatype conversion

            /* String s = "1234";
             int a2 =int.Parse(s);
             int a3 = Convert.ToInt32(s);

             Console.WriteLine(a2);
             Console.WriteLine(a3);*/

            /* int i = 1000;
             byte j =(byte)i;

             Console.WriteLine(j);


             var number = "45";
             int q = int.Parse(number);
             Console.WriteLine(q);
             */
            try
            {
                var num = "12345";
                byte z = Convert.ToByte(num);
                Console.WriteLine(z);
            }catch(Exception e)
            {
                Console.WriteLine("Overflow exception");
            }
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamScore
{
    class Program
    {
        static void Main(string[] args)
        {
            const int exam1 = 80;
            const int exam2 = 85;
            const int exam3 = 90;
            const int exam4 = 77;
            const int exam5 = 75;
            double average;
            average = (exam1 + exam2 + exam3 + exam4 + exam5) / 5;
            
            Console.WriteLine("Mark of exam1 {0}\nMark of exam2 {1}\nMark of exam3 {2}\nMark of exam4 {3}\nMark of exam5 {4}", exam1, exam2, exam3, exam4, exam5);
            Console.WriteLine("Average Mark is {0:F2}", average);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 24. Вычислить частичную сумму ряда S=2/(1*3)+3 / (2 * 4) + 4 / (3 * 5) +⋯
        Вычисление прекратить, когда сумма ряда станет больше 10. */

namespace Lab_3_1_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 2;
            double sum = 0;
            while (sum < 10)
            {
                sum += n / ((n-1) * (n+1));
                Console.WriteLine(n + " " + sum);
                n++;
            }
            Console.ReadKey();
        }
    }
}

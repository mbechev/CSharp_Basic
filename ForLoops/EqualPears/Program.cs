using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPears
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum1 = 0;
            double sum2 = 0;
            double diff = 0;
            double biggestdiff = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                if (i == 0)
                    sum2 = number + number2;

                else
                {
                    sum1 = number + number2;
                    if (diff > biggestdiff)
                        biggestdiff = diff;
                }
                sum1 = number + number2;
               
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double Points = double.Parse(Console.ReadLine());

            double bonus = 0;

            if (Points <= 100)
            {
                bonus = 5;
            }
            else if (Points <= 1000)
            {
                bonus = Points * 0.2;
            }

            else
            {
                bonus = 0.1 * Points;
            }

            if (Points % 2 == 0)
            {
                bonus++;
            }

            if (Points % 10 == 5)
            {
                bonus += 2;
            }

            double total = bonus + Points;

            Console.WriteLine($"Bonus Score: {bonus}");
            Console.WriteLine($"Total Score: {total}");
        }
    }
}

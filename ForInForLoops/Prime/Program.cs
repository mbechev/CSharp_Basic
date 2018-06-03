using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double square = (int)Math.Sqrt(number);
            bool isPrime = true;
            for (int i = 2; i <= square; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }                
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }
    }
}

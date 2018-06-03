using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            try
            {
                while (true)
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine($"The number is not even.");
                }
                Console.WriteLine($"Even number entered: {n}");

            }
            catch (Exception)
            {
                while (true)
                {
                    Console.WriteLine("Invalid number");
                    
                }
            }
        }
    }
}




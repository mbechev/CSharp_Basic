using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Entered number is even: {n}");
                    }
                    
                    else
                    {
                        Console.WriteLine("You entered not even number !");
                    }
                    break;                    
                }

                catch
                {
                    Console.WriteLine("Invalid number");
                }

            }                
        }
    }
}

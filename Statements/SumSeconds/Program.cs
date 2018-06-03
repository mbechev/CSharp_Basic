using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int first = int.Parse(Console.ReadLine());
            int second =int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            
            int totalSeconds = first + second + third;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            Console.Write($"{minutes}:");

            if (seconds <10)
            {
                Console.WriteLine("0" + seconds);
            }
            else
            {
                Console.WriteLine(seconds);
            }

            
               



        }
    }
}

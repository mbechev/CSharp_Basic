using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evens = 0;
            int odds = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evens += number;
                }
                else
                {
                    odds += number;
                }                
            }

            if (evens == odds)
            {
                Console.WriteLine($"Yes Sum = {evens}");
            }
            else
            {
                int diff = Math.Abs(evens - odds);
                Console.WriteLine($"No Diff = {diff}");
            }
        }
    }
}

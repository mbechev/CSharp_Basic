using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int timeFly = int.Parse(Console.ReadLine());

            int hourInMin = (hour * 60);
            int totalMin = min + timeFly;
            int h = totalMin / 60;
            int m = totalMin % 60;
            if (h > 24)
            {
                Console.WriteLine($"{h - 24}h {m}m");
            }
            else if (h <= 24)
            {
                Console.WriteLine($"{h}h {m}m");
            }
        }
    }
}

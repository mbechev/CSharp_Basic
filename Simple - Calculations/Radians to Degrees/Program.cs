using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = rad/Math.PI*180;
            double degree = Math.Round(deg,0);
            Console.WriteLine("Degree = " +degree);

        }
    }
}

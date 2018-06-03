using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traininLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());  
            double h = double.Parse(Console.ReadLine());   
            if (3 <= h && w >= h && 100 >= w)
            {
                double visochina = h * 100 - 100;
                double duljina = w * 100;

                double deskRow = Math.Floor(visochina / 70);
                double deskCol = Math.Floor(duljina / 120);
                double desk = deskCol * deskRow;
                Console.WriteLine(desk-3);
            }
        }
    }
}

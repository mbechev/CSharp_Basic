using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double sandPrice = double.Parse(Console.ReadLine());
            double woodPrice = double.Parse(Console.ReadLine());

            double totalArea = width * hight;
            double sandArea = (hight - (0.2 + 0.2))*(width - (0.2 + 0.2));
            double woodArea = totalArea - sandArea;

            double sandQuantity = Math.Ceiling(sandArea * 20);
            double woodQuantity = Math.Ceiling(woodArea / (2.2 * 0.2));

            double priceForSand = sandPrice * sandQuantity;
            double priceForWood = woodPrice * woodQuantity;

            double totalPrice = priceForSand + priceForWood;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}

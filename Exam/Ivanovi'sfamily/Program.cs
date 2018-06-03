using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanovi_sfamily
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double firstGiftPrice = double.Parse(Console.ReadLine());
            double secondGiftPrice = double.Parse(Console.ReadLine());
            double thirdGiftPrice = double.Parse(Console.ReadLine());

            double totalGiftPrice = firstGiftPrice + secondGiftPrice + thirdGiftPrice;
            double endbudget = (budjet - totalGiftPrice);
            endbudget -= endbudget * 0.1;
            Console.WriteLine($"{endbudget:f2}");

        }
    }
}

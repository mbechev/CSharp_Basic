using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int DaysAway = int.Parse(Console.ReadLine());
            int FoodLeft = int.Parse(Console.ReadLine());
            double firstDeerKg = double.Parse(Console.ReadLine());
            double secondDeerKg = double.Parse(Console.ReadLine());
            double thirdDeerKg = double.Parse(Console.ReadLine());

            //nujna hrana na elenite
            double firstDeerNeed = DaysAway * firstDeerKg;
            double secondDeerNeed = DaysAway * secondDeerKg;
            double thirdDeerNeed = DaysAway * thirdDeerKg;
            double totalFoodNeed = firstDeerNeed + secondDeerNeed + thirdDeerNeed;

            if (totalFoodNeed > FoodLeft)
            {
                double ostatyk = Math.Abs(totalFoodNeed - FoodLeft);
                Console.WriteLine($"{Math.Ceiling(ostatyk)} more kilos of food are needed.");
            }
            else
            {
                double ostatyk = FoodLeft - totalFoodNeed;
                Console.WriteLine($"{Math.Floor(ostatyk)} kilos of food left.");
            }
        }
    }
}

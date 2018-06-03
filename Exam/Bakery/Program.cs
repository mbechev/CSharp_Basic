using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingWeightDough = int.Parse(Console.ReadLine());
            double weightFirstProduct = int.Parse(Console.ReadLine());
            double priceFirstProduct = double.Parse(Console.ReadLine());
            int numberSoldProduct = int.Parse(Console.ReadLine());

            int numberSoldSweets = int.Parse(Console.ReadLine());
            double priceSweets = priceFirstProduct + (priceFirstProduct * 0.25);
            double weightSweets = weightFirstProduct - (weightFirstProduct * 0.2);
                       
            double dailyIncome = numberSoldProduct * priceFirstProduct;                       
            double needDough = weightFirstProduct * numberSoldProduct; 
            double doughLeft = startingWeightDough - needDough;   
            double doughtSweets = startingWeightDough - doughLeft; 

            double needDoughSweets = numberSoldSweets * weightSweets;                      
            double nightIncome = numberSoldSweets * priceSweets;
            //razhodi za testo
            double doughCost = ((startingWeightDough + doughtSweets)/1000)*4;

            double totalIncome = (dailyIncome + nightIncome) - doughCost;
            double totalDough = needDough + needDoughSweets;
            Console.WriteLine($"Pure income: {totalIncome:f2} lv.");
            Console.WriteLine($"Dough used: {totalDough:f0} g.");                 
          
        }
    }
}

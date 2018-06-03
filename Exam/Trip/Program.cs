using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometres = double.Parse(Console.ReadLine());
            double razhod = double.Parse(Console.ReadLine());
            double priceGasoline = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double razhod100 = kilometres * (razhod / 100);
            double totalCost = razhod100 * priceGasoline;

            double moneyNeed = Math.Abs(budget - totalCost);
            double eachPerson = (budget / 5);

            if (budget >= totalCost)
            {
                Console.WriteLine($"You can take a trip. {moneyNeed:f2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {eachPerson:f2} money.");
            }
        }
    }
}

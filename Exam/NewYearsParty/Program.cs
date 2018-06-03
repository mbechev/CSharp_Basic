using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearsParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestNumber = int.Parse(Console.ReadLine());
            double ivanoviBudget = double.Parse(Console.ReadLine());

            double couvert = 20 * guestNumber;
            double moneyLeft = ivanoviBudget - couvert;

            double moneyFireworks = moneyLeft * 0.4;
            double moneyDonation = moneyLeft - moneyFireworks;

            if (moneyLeft < 0)
            {
                double borch = Math.Abs(moneyLeft);
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {borch:f0} lv more.");
            }
            else
            {
                Console.WriteLine($"Yes! {moneyFireworks:f0} lv are for fireworks and {moneyDonation:f0} lv are for donation.");
            }
        }
    }
}

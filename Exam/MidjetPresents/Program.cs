using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidjetPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int midgetNum = int.Parse(Console.ReadLine());
            int santasBudget = int.Parse(Console.ReadLine());

            double sandClock = 2.20;
            double magnet = 1.50;
            double cup = 5.00;
            double Tshirt = 10.00;


            double totalPresentSum = 0;
            for (int i = 1; i <= midgetNum; i++)
            {
                string present = Console.ReadLine();
                switch (present)
                {
                    case "sand clock":
                        totalPresentSum += sandClock;
                        break;
                    case "magnet":
                        totalPresentSum += magnet;
                        break;
                    case "cup":
                        totalPresentSum += cup;
                        break;
                    case "t-shirt":
                        totalPresentSum += Tshirt;
                        break;
                }
            }

            double money = Math.Abs(totalPresentSum - santasBudget);
            if (santasBudget < totalPresentSum)
            {
                Console.WriteLine($"Santa Claus will need {money:f2} more leva.");
            }
            else
            {
                Console.WriteLine($"Santa Claus has {money:f2} more leva left!");
            }
        }
    }
}

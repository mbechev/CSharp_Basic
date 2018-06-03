using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());                 //Lilly's age
            double priceLaundry = double.Parse(Console.ReadLine());  //price for laundry
            int toy = int.Parse(Console.ReadLine());                 //price for toy

            double moneyFromToy = 0;   // money from toys
            double moneyFromBTH = 0;   // money from birthday
            double doubleMoney = 0;    //+10 money every even year
            if (age >= 1 && age <= 77 && toy >= 1 && toy <= 40 && priceLaundry >= 1.00 && priceLaundry <= 10000.00)   //statements to be true
            {
                for (int i = 1; i <= age; i++)
                {
                    if (i % 2 == 0)
                    {
                        moneyFromBTH += 9 + (doubleMoney);   //sum money from birthday and theese that are rise from the statements
                    }
                    if (i % 2 != 0)
                    {
                        moneyFromToy += toy;
                    }
                    if (i > 1 && i % 2 == 0)           //+10 money every even year
                    { doubleMoney += 10; }
                }
            }
            double TotalMoney = moneyFromBTH + moneyFromToy;

            if (TotalMoney >= priceLaundry)
            {
                double rest = TotalMoney - priceLaundry;
                Console.WriteLine($"Yes! {rest:F2}");
            }
            else
            {
                double deficit = priceLaundry - TotalMoney;
                Console.WriteLine($"No! {deficit:F2}");
            }
        }
    }
}

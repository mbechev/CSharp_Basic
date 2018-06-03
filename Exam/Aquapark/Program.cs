using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double hoursInPark = double.Parse(Console.ReadLine());
            int numPeople = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            double priceStay = 0;
            double totalPrice = 0;
            
            if (month == "march" || month == "april" || month == "may")
            {
                switch (partOfDay)
                {
                    case "day":
                        priceStay = 10.50;
                        break;
                    case "night":
                        priceStay = 8.4;
                        break;
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                switch (partOfDay)
                {
                    case "day":
                        priceStay = 12.60;
                        break;
                    case "night":
                        priceStay = 10.20;
                        break;
                }
            }

            if (numPeople >= 4)
            {
                priceStay -= priceStay * 0.1;
            }
           

            if (hoursInPark >= 5)
            {
                priceStay -= priceStay * 0.5;
            }
            
            totalPrice = priceStay * numPeople * hoursInPark;

            Console.WriteLine($"Price per person for one hour: {priceStay:f2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:f2}");
        }
    }
}

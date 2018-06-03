using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanoviHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int nightCount = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transportType = Console.ReadLine();

            double hotelPrice = 0;
            double transportPrice = 0;

            if (nightCount <= 10)
            {
                switch (destination)
                {
                    case "Miami":
                        hotelPrice = (2 * 24.99 + 3 * 14.99);
                        break;
                    case "Canary Islands":
                        hotelPrice = (2 * 32.50 + 3 * 28.50);
                        break;
                    case "Philippines":
                        hotelPrice = (2 * 42.99 + 3 * 39.99);
                        break;
                }
            }
            else if (nightCount > 15)
            {
                switch (destination)
                {
                    case "Miami":
                        hotelPrice = (2 * 20.00 + 3 * 10.00);
                        break;
                    case "Canary Islands":
                        hotelPrice = (2 * 28.00 + 3 * 22.00);
                        break;
                    case "Philippines":
                        hotelPrice = (2 * 38.50 + 3 * 32.40);
                        break;
                }
            }
            else
            {
                switch (destination)
                {
                    case "Miami":
                        hotelPrice = (2 * 22.99 + 3 * 11.99);
                        break;
                    case "Canary Islands":
                        hotelPrice = (2 * 30.50 + 3 * 25.60);
                        break;
                    case "Philippines":
                        hotelPrice = (2 * 41.00 + 3 * 36.00);
                        break;
                }
            }

            if (transportType == "train")
            {
                transportPrice = 2 * 22.30 + 3 * 12.50;
            }
            else if (transportType == "bus")
            {
                transportPrice = 2 * 45.00 + 3 * 37.00;
            }
            else if (transportType == "airplane")
            {
                transportPrice = 2 * 90.00 + 3 * 68.50;
            }
            double PricewithDog = hotelPrice + (hotelPrice * 0.25);
            double totalPrice = transportPrice +PricewithDog * nightCount;
            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}


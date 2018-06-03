using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInHotel = int.Parse(Console.ReadLine());
            string roomtype = Console.ReadLine();
            string SantasOpinnion = Console.ReadLine();

            double roomOfOnePersonPrice = 18.00;
            double apartmentPrice = 25.00;
            double presidentApartmentPrice = 35.00;

            double stayPrice = 0;

            switch (roomtype)
            {
                case "room for one person":
                    stayPrice = (daysInHotel - 1) * roomOfOnePersonPrice;
                    break;
                case "apartment":
                    if (daysInHotel > 15)
                    {
                        stayPrice = (daysInHotel - 1) * apartmentPrice;
                        double promotion = stayPrice - (stayPrice * 0.5);
                        stayPrice = promotion;
                    }
                    else if (daysInHotel < 10)
                    {
                        stayPrice = (daysInHotel - 1) * apartmentPrice;
                        double promotion = stayPrice - (stayPrice * 0.3);
                        stayPrice = promotion;
                    }
                    else
                    {
                        stayPrice = (daysInHotel - 1) * apartmentPrice;
                        double promotion = stayPrice - (stayPrice * 0.35);
                        stayPrice = promotion;
                    }
                    break;
                case "president apartment":
                    if (daysInHotel > 15)
                    {
                        stayPrice = (daysInHotel - 1) * presidentApartmentPrice;
                        double promotion = stayPrice - (stayPrice * 0.2);
                        stayPrice = promotion;
                    }
                    else if (daysInHotel < 10)
                    {
                        stayPrice = (daysInHotel - 1) * presidentApartmentPrice;
                        double promotion = stayPrice - (stayPrice * 0.1);
                        stayPrice = promotion;
                    }
                    else
                    {
                        stayPrice = (daysInHotel - 1) * presidentApartmentPrice;
                        double promotion = stayPrice - (stayPrice * 0.15);
                        stayPrice = promotion;
                    }
                    break;
            }
            switch (SantasOpinnion)
            {
                case "positive":
                    double bonusMoneyPaid = stayPrice + (stayPrice * 0.25);
                    stayPrice = bonusMoneyPaid;
                    break;
                case "negative":
                    double MoneyPaid = stayPrice - (stayPrice * 0.1);
                    stayPrice = MoneyPaid;
                    break;
            }
            Console.WriteLine($"{stayPrice:f2}");
        }
    }
}

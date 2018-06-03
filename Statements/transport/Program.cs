using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();


            double price = 0;

            if (km >= 100)
            {
                if (dayOrNight == "day")
                { price = km * 0.06; }
                else if (dayOrNight == "night")
                { price = km * 0.06; }
            }

            else if (km >= 20)
            {
                if (dayOrNight == "day")
                { price = km * 0.09; }
                else if (dayOrNight == "night")
                { price = km * 0.09; }
            }

            else
            {
                if (dayOrNight == "day")
                { price = 0.70 + km * 0.79; }
                else if (dayOrNight == "night")
                { price = 0.70 + km * 0.90; }
            }





            Console.WriteLine($"{price:f2}");


        }

    }


}



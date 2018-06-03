using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inch_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double currency = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double BGN = 1;
            double USD = 1.79549;
            double GBP = 2.53405;
            double EUR = 1.95583;
            double result = 0;

            if (input == "BGN")
            {
                if (output == "USD")
                {
                    result = currency * BGN / USD;

                }
                else if (output == "EUR")
                {
                    result = currency * BGN / EUR;

                }
                else if (output == "GBP")
                {
                    result = currency * BGN / GBP;
                }
            }

            else if (input == "USD")
            {
                if (output == "BGN")
                {
                    result = currency * USD / BGN;
                }
                else if (output == "EUR")
                {
                    result = currency * USD / EUR;
                }
                else if (output == "GBP")
                {
                    result = currency * USD / GBP;
                }
            }

            else if (input == "EUR")
            {
                if (output == "BGN")
                {
                    result = currency * EUR / BGN;
                }
                else if (output == "USD")
                {
                    result = currency * EUR / USD;
                }
                else if (output == "GBP")
                {
                    result = currency * EUR / GBP;
                }
            }

            else if (input == "GBP")
            {
                if (output == "BGN")
                {
                    result = currency * GBP / BGN;
                }
                else if (output == "EUR")
                {
                    result = currency * GBP / EUR;
                }
                else if (output == "USD")
                {
                    result = currency * GBP / USD;
                }


            }

            double result2 = Math.Round(result, 8);
            Console.WriteLine(result2);
            

        }

    }      
}

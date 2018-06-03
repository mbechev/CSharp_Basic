using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wrappingPaper = int.Parse(Console.ReadLine()); //rolki opakovachna hartiq
            int skirting = int.Parse(Console.ReadLine());   // rolki plat
            double glueLitres = double.Parse(Console.ReadLine()); //lepilo v litri
            int percentagePromotion = int.Parse(Console.ReadLine()); // promocionalno namalenie

            double wrappingPrice = 5.80;
            double skirtingPrice = 7.20;
            double gluePrice = 1.20;

            double totalWrapPrice = wrappingPaper * wrappingPrice;
            double totalSkirtPrice = skirting * skirtingPrice;
            double totalGluePrice = gluePrice * glueLitres;


            double totalPrice = totalWrapPrice + totalSkirtPrice + totalGluePrice;
            double Promotion = totalPrice - ((totalPrice * percentagePromotion) / 100);
            Console.WriteLine($"{Promotion:f3}");
        }
    }
}

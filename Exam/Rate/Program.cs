using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of money: ");
            double money = double.Parse(Console.ReadLine());
            Console.Write("Enter rate: ");
            int month = int.Parse(Console.ReadLine());

            double simpleRate = money;
            double complexRate = money;

            for (int i = 1; i <= month; i++)
            {
                double simple = simpleRate + (0.03 * money);
                simpleRate = simple;
                for (int k = i; k <= i; k++)
                {
                    double complex = complexRate + (0.027 * complexRate);
                    complexRate = complex;
                }
            }

            Console.WriteLine($"Simple interest rate: {simpleRate:f2} lv.");
            Console.WriteLine($"Complex interest rate: {complexRate:f2} lv.");
            if (simpleRate > complexRate)
            {
                double razlika = simpleRate - complexRate;
                Console.WriteLine($"Choose a simple interest rate. You will win {razlika:f2} lv.");
            }
            else
            {
                double razlika = complexRate - simpleRate;
                Console.WriteLine($"Choose a complex interest rate. You will win {razlika:f2} lv.");
            }
        }
    }
}

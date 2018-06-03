using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEevenPossition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double Oddsum = 0;
            double Oddmin = double.MaxValue;
            double Oddmax = double.MinValue;

            double Evensum = 0;
            double Evenmin = double.MaxValue;
            double Evenmax = double.MinValue;

            for (double i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Evensum += number;

                    if (number > Evenmax)
                    {
                        Evenmax = number;
                    }
                    if (number < Evenmin)
                    {
                        Evenmin = number;
                    }
                }

                else
                {
                    Oddsum += number;

                    if (number > Oddmax)
                    {
                        Oddmax = number;
                    }
                    if (number < Oddmin)
                    {
                        Oddmin = number;
                    }
                }
            }

            Console.WriteLine($"OddSum = {Oddsum}");        // Сума на всички числа на нечетни позиции

            if (Oddmin != double.MaxValue)                  // Най-малкото число на нечетна позиция
            {
                Console.WriteLine($"OddMin ={Oddmin}");
            }
            else
            {
                Console.WriteLine("OddMin = No");
            }

            if (Oddmax != double.MinValue)                   //Най-голямото число на нечетна позиция
            {
                Console.WriteLine($"OddMax = {Oddmax}");
            }
            else
            {
                Console.WriteLine("OddMax = No");
            }

            Console.WriteLine($"EvenSum = {Evensum}");       //Сума на всички числа на чеетни позиции
            if (Evenmin != double.MaxValue)                  //Най-малкото число на четна позизция
            {
                Console.WriteLine($"EvenMin = {Evenmin}");
            }
            else
            {
                Console.WriteLine("EvenMin = No");
            }
            if (Evenmax != double.MinValue)                  //Най-голямото число на четна позиция
            {
                Console.WriteLine($"EvenMax ={Evenmax}");
            }
            else
            {
                Console.WriteLine("EvenMax = No");
            }

        }
    }
}

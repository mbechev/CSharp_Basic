using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var score = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;

            

            if (score > 1000)
            {
                bonusScore = score * 0.10;
            }

            else if (score > 101)
            {
                bonusScore = score *0.20;
            }

            else 
            {
                bonusScore = +5;
            }



             if (score % 10 == 5)
             {
                bonusScore += 2;
             }
            else if (score %2 ==0)
            {
                bonusScore += 1;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(score + bonusScore);
        }
    }
}

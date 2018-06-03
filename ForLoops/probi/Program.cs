using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int previousCouple = 0;
            int maxDiff = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());


                int couple = firstNum + secondNum;

                if (i == 0)
                {
                    previousCouple = couple;
                }
                else if (couple != previousCouple)
                {
                    int diff = Math.Abs(previousCouple - couple);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff; ;
                    }
                    previousCouple = couple;               
                }
            }

            if (maxDiff == int.MinValue)
            {
                Console.WriteLine($"Yes , value = {previousCouple}");
            }
            else
            {
                Console.WriteLine($"No maxdiff = {maxDiff}");
            }
        }
    }
}

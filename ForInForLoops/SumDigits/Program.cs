using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();

            int totalSum = 0;

            for (int i = 0; i < numberStr.Length; i++)
            {
                int digits = numberStr[i] - '0';
                totalSum += digits;
            }
            Console.WriteLine(totalSum);
        }
    }
}

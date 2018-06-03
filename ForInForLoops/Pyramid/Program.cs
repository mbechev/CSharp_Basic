using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int curretntNumber = 1;
            for (int row = 0 ; curretntNumber <= number; row++)
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.Write($"{curretntNumber} ");
                    curretntNumber++;
                    if (curretntNumber>number)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

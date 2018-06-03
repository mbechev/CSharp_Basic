    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNum = 1;
            int secondNum = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = secondNum;
                secondNum += firstNum;
                firstNum = temp;  
            }
            Console.WriteLine(firstNum);
        }
    }
}

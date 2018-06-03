using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int leftSide = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSide += number;                
            }
            

            int rightSide = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSide += number;
            }
            

            if (leftSide==rightSide)
            {
                Console.WriteLine($"Yes, Sum = {leftSide}");
            }
            else
            {
                int diff = Math.Abs(leftSide - rightSide);
                Console.WriteLine($"No, Diff = {diff}");
            }
                    
                    
        }
    }
}

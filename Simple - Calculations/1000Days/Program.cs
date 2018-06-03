

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ThousandDays
{
    class ThousandDays
    {
        static void Main(string[] args)
        {
            Console.Write("What is the figure: ");

            string square = "square";
            string circle = "circle";
            string rectangle = "rectangle";
            string triangle = "triangle";

            string figure = Console.ReadLine();

            //The idea is that we have to read the number from the "IF" statement !!!
                        
        
            double area = 0;
            if (figure == square )
            {
                double firstNum = double.Parse(Console.ReadLine());
                area = firstNum * firstNum;
            }
            else if (figure==circle)
            {
                double firstNum = double.Parse(Console.ReadLine());
                area = firstNum * firstNum * Math.PI;
            }

            
            if (figure==rectangle)
                
            {
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                 area = firstNum * secondNum;
            }
            else if (figure==triangle)
            {
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                 area= firstNum * secondNum / 2;
            }
            Console.WriteLine($"Area is: {area:f3}");
          
            
        }
    }
}
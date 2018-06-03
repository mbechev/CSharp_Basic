using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNum = double.Parse(Console.ReadLine());
            string inputType = Console.ReadLine();
            string outputType = Console.ReadLine();

            //double m = 1;
            //double mm = 1000;
            //double cm = 100;
            //double mile = 0.000621371192;
            //double inches = 39.3700787;
            //double km = 0.001;
            //double yard = 1.0936133;
            //double feet = 3.2808399;


            //Ekvivalent na metura

            if (inputType=="m")
            { inputNum = inputNum / 1; }
            else if (inputType == "mm")
            { inputNum = inputNum / 1000; }
            else if (inputType == "cm")
            { inputNum = inputNum / 100; }
            else if (inputType == "mi")
            { inputNum = inputNum / 0.000621371192; }
            else if (inputType == "in")
            { inputNum = inputNum / 39.3700787; }
            else if (inputType == "km")
            { inputNum = inputNum / 0.001; }
            else if (inputType == "yd")
            { inputNum = inputNum / 1.0936133; }
            else if (inputType == "ft")
            { inputNum = inputNum / 3.2808399; }

            
            if (outputType =="m")
            { inputNum = inputNum * 1; }            
            else if (outputType=="mm")
            { inputNum = inputNum * 1000; }
            else if (outputType =="cm")
            { inputNum = inputNum * 100; }
            else if (outputType == "mi")
            { inputNum = inputNum * 0.000621371192; }
            else if (outputType == "in")
            { inputNum = inputNum * 39.3700787; }
            else if (outputType == "km")
            { inputNum = inputNum * 0.001; ; }
            else if (outputType == "yd")
            { inputNum = inputNum * 1.0936133; }
            else if (outputType == "ft")
            { inputNum = inputNum * 3.2808399; }

            Console.WriteLine($"{inputNum:f8} {outputType}");
            
        }
    }
}

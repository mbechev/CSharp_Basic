﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inch_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cm = inches * 2.54;
            Console.WriteLine("Centimetres = " + cm);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Weight in Pound : ");
            double pound = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height in inches : ");
            double inches = Convert.ToDouble(Console.ReadLine());
            double w = pound * 0.45359237;
            double h = inches * 0.0254;
            Console.WriteLine("Body Index Mass : " + (w / (h * h)));
        }
    }
}

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
            Console.WriteLine("Enter Integer Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary : " + (Convert.ToString(num1, 2)));
        }
    }
}

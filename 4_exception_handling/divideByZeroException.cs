﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                int ans = num / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

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
            int flag = 0;
            Console.WriteLine("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    flag = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Prime Number");
                }
            }
        }
    }
}

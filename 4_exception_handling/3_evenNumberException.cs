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
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even Number : " + num);
                }
                else
                {
                    throw new OddNumberException("Not Even Number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class OddNumberException : Exception
    {
        public OddNumberException(String message) : base(message) { }

    }
}

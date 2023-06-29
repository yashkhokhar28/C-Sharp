using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum : "+(num1 + num2));
        }
    }
}

using System;
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
            Console.Write("Enter the principal balance = ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter interest rate= ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter compound frequency / year = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year  = ");
            int t = Convert.ToInt32(Console.ReadLine());

            double amount = p * Math.Pow((1 + r / (100 * n)), n * t);

            double ci = amount - p;

            Console.WriteLine("Compound interest = " + Math.Round(ci, 2));
        }
    }
}
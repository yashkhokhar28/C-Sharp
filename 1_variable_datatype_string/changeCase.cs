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
            Console.Write("Enter Lower Case String : ");
            String u = Console.ReadLine();
            Console.Write("Enter  Upper Case String : ");
            String l = Console.ReadLine();
            Console.WriteLine("Lower to Upper : " + l.ToUpper());
            Console.WriteLine("Upper to Lower : " + u.ToLower());
        }
    }
}

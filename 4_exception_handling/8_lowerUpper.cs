﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        String oldString = "Yash Khokhar";
        String newString = "";
        foreach (char c in oldString)
        {
            if (Char.IsUpper(c))
            {
                newString += c.ToString().ToLower();
            }
            else
            {
                newString += c.ToString().ToUpper();
            }
        }
        Console.WriteLine("Result = "+newString);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int a = Convert.ToInt32(number, 16);
            Console.WriteLine(a);
        }
    }
}

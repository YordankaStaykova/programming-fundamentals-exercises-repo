﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            NameMethod(name);
        }
        static void NameMethod (string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", TriangleArea(side, height));
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", SquareArea(side));
            }
            else if (type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", RectangleArea(width, height));
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CircleArea(radius));
            }
        }
        static double TriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }
        static double SquareArea(double side)
        {
            return side * side;
        }
        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
        static double CircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }
    }
}

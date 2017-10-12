using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
            {
                Console.WriteLine(Math.Round(resultFace(side), 2));
            }
            else if(parameter == "space")
            {
                Console.WriteLine(Math.Round(resultSpace(side), 2));
            }
            else if(parameter == "volume")
            {
                Console.WriteLine(Math.Round(resultVolume(side),2));
            }
            else if(parameter == "area")
            {
                Console.WriteLine(Math.Round(resultArea(side), 2));
            }
        }
        static double resultFace (double side)
        {
            return Math.Sqrt(2 * side * side);
        }
        static double resultSpace (double side)
        {
            return Math.Sqrt(3 * side * side);
        }
        static double resultVolume (double side)
        {
            return side * side * side;
        }
        static double resultArea (double side)
        {
            return side * side * 6;
        }
    }
}

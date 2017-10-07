using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string Hex = Convert.ToString(a, 16).ToUpper();
            string Binary = Convert.ToString(a, 2).ToUpper();
            Console.WriteLine(Hex);
            Console.WriteLine(Binary);
        }
    }
}

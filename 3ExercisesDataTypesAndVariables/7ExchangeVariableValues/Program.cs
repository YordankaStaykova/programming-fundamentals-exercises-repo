using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {number1}");
            Console.WriteLine($"b = {number2}");
            var numberOneNew = number2;
            var numberTwoNew = number1;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {numberOneNew}");
            Console.WriteLine($"b = {numberTwoNew}");
        }
    }
}

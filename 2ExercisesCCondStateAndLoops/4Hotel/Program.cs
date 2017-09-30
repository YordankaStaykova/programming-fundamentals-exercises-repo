using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            if (month == "May" || month == "October")
            {
                var studioPrice = 50.0;
                var doublePrice = 65.0;
                var suitePrice = 75.0;
                if (month == "May" && nights > 7)
                {
                    studioPrice -= studioPrice * 0.05;
                    Console.WriteLine($"Studio: {nights * studioPrice:F2} lv.");
                    Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                    Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
                else if (month == "October" && nights >7)
                {
                        studioPrice -= studioPrice * 0.05;
                        Console.WriteLine($"Studio: {((nights-1) * studioPrice):F2} lv.");
                        Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                        Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {nights * studioPrice:F2} lv.");
                    Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                    Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
            }
            else if (month == "June" || month == "September")
            {
                var studioPrice = 60.0;
                var doublePrice = 72.0;
                var suitePrice = 82.0;
                if (nights > 14)
                {
                    doublePrice -= doublePrice * 0.1;
                    Console.WriteLine($"Studio: {nights * studioPrice:F2} lv.");
                    Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                    Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
                else if (month == "September" && nights > 7)
                {
                    Console.WriteLine($"Studio: {((nights-1) * studioPrice):F2} lv.");
                    Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                    Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {nights * studioPrice:F2} lv.");
                    Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                    Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                var studioPrice = 68.0;
                var doublePrice = 77.0;
                var suitePrice = 89.0;
                if (nights > 14)
                {
                    suitePrice -= suitePrice * 0.15;
                    Console.WriteLine($"Studio: {nights * studioPrice:F2} lv.");
                    Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                    Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {nights * studioPrice:F2} lv.");
                    Console.WriteLine($"Double: {nights * doublePrice:F2} lv.");
                    Console.WriteLine($"Suite: {nights * suitePrice:F2} lv.");
                }
            }
        }
    }
}

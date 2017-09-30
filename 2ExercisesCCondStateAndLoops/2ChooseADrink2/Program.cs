using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (profession == "Athlete")
            {
                var totalPrice = quantity * 0.7;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                var totalPrice = quantity * 1;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                var totalPrice = quantity * 1.7;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else
            {
                var totalPrice = quantity * 1.2;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
        }
    }
}

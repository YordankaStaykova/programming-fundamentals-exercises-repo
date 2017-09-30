using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            var sum = 0;
            while (ingredient != "Bake!")
            {
                sum = sum + 1;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
            } 
            Console.WriteLine($"Preparing cake with {sum} ingredients.");
        }
    }
}

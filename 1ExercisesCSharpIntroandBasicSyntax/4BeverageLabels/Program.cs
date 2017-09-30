using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());
            double energyContent100 = energyContent * (volume / 100);
            double sugarContent100 = sugarContent * (volume / 100);
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent100}kcal, {sugarContent100}g sugars");
        }
    }
}

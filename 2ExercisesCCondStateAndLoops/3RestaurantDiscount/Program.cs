using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            var price = 0.0;
            var pricePackage = 0.0;
            var totalPrice = 0.0;
            if (groupSize <= 50)
            {
                string hall = "Small Hall";
                if (package == "Normal")
                {
                    price = 2500;
                    pricePackage = 500;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.05;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
                else if (package == "Gold")
                {
                    price = 2500;
                    pricePackage = 750;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.1;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
                else if (package == "Platinum")
                {
                    price = 2500;
                    pricePackage = 1000;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.15;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                string hall = "Terrace";
                if (package == "Normal")
                {
                    price = 5000;
                    pricePackage = 500;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.05;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
                else if (package == "Gold")
                {
                    price = 5000;
                    pricePackage = 750;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.1;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
                else if (package == "Platinum")
                {
                    price = 5000;
                    pricePackage = 1000;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.15;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                string hall = "Great Hall";
                if (package == "Normal")
                {
                    price = 7500;
                    pricePackage = 500;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.05;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
                else if (package == "Gold")
                {
                    price = 7500;
                    pricePackage = 750;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.1;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
                else if (package == "Platinum")
                {
                    price = 7500;
                    pricePackage = 1000;
                    totalPrice = (price + pricePackage);
                    var Dprice = totalPrice - totalPrice * 0.15;
                    var Pprice = Dprice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {Pprice:F2}$");
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}

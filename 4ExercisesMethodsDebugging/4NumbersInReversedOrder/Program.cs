using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine(Reverse(n));
        }
        static string Reverse (string n)
        {
            string result = "";
            for (int i = n.Length-1; i >= 0; i--)
            {
                result += n[i];
            }
            return result;
        }
    }
}

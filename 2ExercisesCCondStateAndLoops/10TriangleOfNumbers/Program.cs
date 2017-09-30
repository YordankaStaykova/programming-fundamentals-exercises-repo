using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write($"{num} ");
                    if (num > n)
                        break;
                }
                num++;
                if (num > n)
                    break;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

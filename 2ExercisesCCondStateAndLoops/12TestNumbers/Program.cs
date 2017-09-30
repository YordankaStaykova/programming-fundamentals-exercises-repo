using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSumB = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;
            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    if (sum >= maxSumB)
                    {
                        break;
                    }
                    else
                    {
                        sum = sum + ((i * j )* 3);
                    }
                    count++;
                }
                if (sum >= maxSumB)
                {
                        break;
                }
            }
            if ((sum >= maxSumB))
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSumB}");
            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}

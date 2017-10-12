using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialResult = Result(n);
            Console.WriteLine(NumberZeroes(factorialResult));
        }
        static BigInteger Result(BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                BigInteger factorialResult = factorial * i;
                factorial = factorialResult;
            }
            return factorial;
        }
        static BigInteger NumberZeroes (BigInteger factorial)
        {
            BigInteger count = 0;
            while (factorial % 10 == 0)
            {
                factorial = factorial / 10;
                count += 1;
            }
            return count;
        }
    }
}

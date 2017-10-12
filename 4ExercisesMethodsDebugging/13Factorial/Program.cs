using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Result(n));
        }
        static BigInteger Result (BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                BigInteger factorialResult = factorial * i;
                factorial = factorialResult;
            }
            return factorial;
        }
    }
}

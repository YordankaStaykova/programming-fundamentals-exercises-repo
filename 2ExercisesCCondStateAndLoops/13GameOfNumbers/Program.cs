using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;
            int iMagic = 0;
            int jMagic = 0;
            int magicNumber = int.Parse(Console.ReadLine());
            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    sum = j + i;
                    if (sum == magicNumber)
                    {
                        iMagic = i;
                        jMagic = j;
                    }
                    count++;
                }
            }
                    
                    if (iMagic != 0)
                    {
                        Console.WriteLine($"Number found! {iMagic} + {jMagic} = {magicNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
                    }
           
            
        }
    }
}

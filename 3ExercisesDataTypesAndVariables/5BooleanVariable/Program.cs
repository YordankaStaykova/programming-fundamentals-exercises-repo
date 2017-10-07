using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            bool num = Convert.ToBoolean(one);
            if (num == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

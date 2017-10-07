using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            Console.WriteLine($"First name: {firstName}");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Last name: {lastName}");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Age: {age}");
            string gender = Console.ReadLine();
            Console.WriteLine($"Gender: {gender}");
            long personalIDNumber = long.Parse(Console.ReadLine());
            Console.WriteLine($"Personal ID: {personalIDNumber}");
            uint uempNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine($"Unique Employee number: {uempNumber}");
        }
    }
}

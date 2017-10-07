using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInM = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float timeS = hours * 60 * 60 + minutes * 60 + seconds;
            float timeH = (timeS / 60) / 60;
            float speedMS = distanceInM / timeS;
            float speedKMH = (distanceInM / 1000) / timeH;
            float speedMH = (distanceInM / 1609) / timeH;
            Console.WriteLine("{0}", speedMS);
            Console.WriteLine("{0}", speedKMH);
            Console.WriteLine("{0}", speedMH);
        }
    }
}

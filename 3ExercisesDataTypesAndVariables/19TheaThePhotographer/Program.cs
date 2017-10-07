using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberPictures = long.Parse(Console.ReadLine());
            long filterTimeSeconds = long.Parse(Console.ReadLine());
            byte filterFactorPerc = byte.Parse(Console.ReadLine());
            long timeUploadSeconds = long.Parse(Console.ReadLine());
            
            long filteredPictures = (long) Math.Ceiling((numberPictures * filterFactorPerc) / 100d);
            long filterTimeAll = numberPictures * filterTimeSeconds;
            long uploadTimeAll = filteredPictures * timeUploadSeconds;
            long totalTime = filterTimeAll + uploadTimeAll;

            TimeSpan totalTimeResult = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", totalTimeResult.Days, totalTimeResult.Hours, totalTimeResult.Minutes, totalTimeResult.Seconds);
        }
    }
}

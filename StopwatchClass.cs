using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programing
{
    public class StopwatchClaass
    {
        public static void SimulateStopwatch()
        {
           
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < 10; i++)
            {               
                Console.WriteLine("hi");               
            }
            stopwatch.Stop();
            
            Console.WriteLine("Time elapsed: {0}", stopwatch.ElapsedMilliseconds);
        }
    }
}

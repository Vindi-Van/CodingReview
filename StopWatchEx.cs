using System;
using System.Diagnostics;
using System.Threading;
 
public static class StopWatchEx
{
    public static void StopWatchTest()
    {
        Stopwatch stopwatch = new Stopwatch();
 
        stopwatch.Start();
        Thread.Sleep(5000);
        stopwatch.Stop();
 
        Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }
}
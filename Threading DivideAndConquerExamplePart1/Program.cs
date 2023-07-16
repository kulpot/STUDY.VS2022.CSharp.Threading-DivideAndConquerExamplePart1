using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

//ref link:https://www.youtube.com/watch?v=PmURwqfNTko&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5&index=11
// Threading Divide and Conquer -- cut data to multiple threads one per CPU available then add it all
//  8 core CPU ---

class MainClass
{
    static byte[] values = new byte[500000000];
    static void GenerateInts()
    {
        var rand = new Random(987);
        for (int i = 0; i < values.Length; i++)
            values[i] = (byte)rand.Next(10);
    }
    static void Main()
    {
        GenerateInts();
        Console.WriteLine("Summing...");
        Stopwatch watch = new Stopwatch();
        watch.Start();
        long total = 0;
        for (int i = 0; i < values.Length; i++)
            total += values[i];
        watch.Stop();
        Console.WriteLine("Total value is: " + total);
        Console.WriteLine("Time to sum: " + watch.Elapsed);
    }
}
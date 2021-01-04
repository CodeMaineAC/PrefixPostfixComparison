using System;
using static System.Console;
using System.Diagnostics;

/*
 * Prefix Versus Postfix Comparison
 * 1/4/2021
 * Compares the efficiency of prefix notation versus postfix. Prefix
 * should be faster but other operations on your computer can affect 
 * this.
 */
class PrefixPostfixComparison
{
    static void Main()
    {
        int LOOPS = 100000000;
        for (int x = 0; x < 10; ++x)
        {
            
            Stopwatch sw = Stopwatch.StartNew();
            for (int y = 0; y < LOOPS; ++y) ;
            sw.Stop();
            Stopwatch sw2 = Stopwatch.StartNew();
            for (int y = 0; y < LOOPS; y++) ;
            sw2.Stop();
            WriteLine("\nTime with prefix increment: {0} ms",
               sw.Elapsed.TotalMilliseconds);
            WriteLine("Time with postfix increment: {0} ms",
               sw2.Elapsed.TotalMilliseconds);

        }

    }
}
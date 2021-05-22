
using System;
using System.Collections.Generic;

class Fibonacci_DP
{
    // O(n)
    private static Dictionary<int, int> cache = new Dictionary<int, int>();

    public static int fibonacciMaster(int n)
    {
        if (cache.ContainsKey(n))
        {
            return cache[n];
        }
        if (n < 2)
        {
            return n;
        }
        cache.Add(n, fibonacciMaster(n - 1) + fibonacciMaster(n - 2));
        return cache[n];
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    public static void MiniMaxSum (long[] arr) {
        long sum = arr.Sum();
        Array.Sort(arr);
        long minimum = sum;
        long maximum = arr[0];

        for (long i = 0; i < arr.Length; i++) {
            long sumMinus = sum - Convert.ToInt64(arr[i]);

            if (sumMinus < minimum) {
                minimum = sumMinus;
            }
            if (sumMinus > maximum) {
                maximum = sumMinus;
            }
        }

        Console.WriteLine("{0} {1}", minimum, maximum);
    }

    static void Main(String[] args)
    {
        long[] arr = Console.ReadLine().Split(' ').Select(s => Int64.Parse(s)).ToArray();
        MiniMaxSum(arr);
    }
}
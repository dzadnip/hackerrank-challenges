using System;
using System.Linq;

class Solution
{
    public static int BirthdayCakeCandles(int n, int[] ar) {
        Array.Sort(ar);
        int heighestCandle = ar[ar.Length - 1];
        int[] matchedItems = Array.FindAll(ar, x => x == heighestCandle);
        return matchedItems.Length;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
        Console.WriteLine(BirthdayCakeCandles(n, ar));
        Console.ReadLine();
    }
}
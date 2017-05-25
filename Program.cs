using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hackerrank_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOfIntegers = Console.ReadLine();

			int[] arr = Console.ReadLine()
                               .Split(' ')
                               .Select(n => Convert.ToInt32(n))
                               .ToArray();
            string output = "";

            for (int i = 1; i <= arr.Length; i++) {
                output = output + arr[arr.Length - i].ToString();
                if (i != arr.Length)
                {
                    output = output + " ";
                }
            }

            Console.WriteLine(output);
        }
    }
}

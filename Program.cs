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
			int[][] arr = new int[6][];
            int largestSum = -100;
            int calculateHourGlassSum = 0;
            //int numberOfHourGlasses = 1;

			for (int arr_i = 0; arr_i < 6; arr_i++)
			{
				arr[arr_i] = Console.ReadLine()
                                    .Split(' ')
                                    .Select(n => Convert.ToInt32(n))
                                    .ToArray();
			}

            for (int i = 0; i < 4; i++)
            {
                int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0;
                calculateHourGlassSum = 0;

                for (int j = 0; j < 4; j++)
                {
                    a = arr[j][i];
                    b = arr[j][i + 1];
                    c = arr[j][i + 2];
                    d = arr[j + 1][i + 1];
                    e = arr[j + 2][i];
                    f = arr[j + 2][i + 1];
                    g = arr[j + 2][i + 2];

                    calculateHourGlassSum = a + b + c + d + e + f + g;

                    //Console.WriteLine("Hour glass: " + numberOfHourGlasses);
                    //Console.WriteLine(a + " " + b + " " + c);
                    //Console.WriteLine("  " + d + "  ");
                    //Console.WriteLine(e + " " + f + " " + g);
                    //Console.WriteLine("Sum: " + calculateHourGlassSum);
                    //Console.WriteLine("");

                    //numberOfHourGlasses = numberOfHourGlasses + 1;

					if (calculateHourGlassSum > largestSum)
					{
						largestSum = calculateHourGlassSum;
					}

					//Console.WriteLine("Largest sum: " + largestSum);
					//Console.WriteLine("");
                }
            }

			Console.WriteLine(largestSum);
		}
    }
}

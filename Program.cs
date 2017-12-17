using System;
using System.Linq;

namespace hack
{
    class MainClass
    {
        public static void DiagonalDifference(int n, int[][] a)
        {
            int sumOfDiagnal1 = 0;
            int sumOfDiagnal2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumOfDiagnal1 = sumOfDiagnal1 + a[i][i];
                sumOfDiagnal2 = sumOfDiagnal2 + a[i][n - i - 1];
            }

            int absoluteDifference = Math.Abs(sumOfDiagnal1 - sumOfDiagnal2);
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                a[a_i] = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
            }
            DiagonalDifference(n, a);
        }
    }
}


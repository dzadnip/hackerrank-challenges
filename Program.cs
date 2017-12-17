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
            }
            for (int i = n - 1; i > 0; i--)
            {
                sumOfDiagnal2 = sumOfDiagnal2 + a[i][i];
            }
            Console.WriteLine(sumOfDiagnal1);
            Console.WriteLine(sumOfDiagnal2);
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = a_temp.Select(s => Int32.Parse(s)).ToArray();
            }
            DiagonalDifference(n, a);
        }
    }
}

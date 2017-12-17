using System;
using System.Linq;

namespace hack
{
    class MainClass
    {
        public static void PlusMinus (int n, int[] arr)
        {
            int positives = 0;
            int negatives = 0;
            int zeros = 0;

            for (int i = 0; i < n; i++) {
                if (arr[i] > 0) {
                    positives++;
                } else if (arr[i] < 0) {
                    negatives++;
                } else if (arr[i] == 0) {
                    zeros++;
                }
            }

            Console.WriteLine("{0:N5}", Decimal.Divide(Convert.ToDecimal(positives), Convert.ToDecimal(n)));
            Console.WriteLine("{0:N5}", Decimal.Divide(Convert.ToDecimal(negatives), Convert.ToDecimal(n)));
            Console.WriteLine("{0:N5}", Decimal.Divide(Convert.ToDecimal(zeros), Convert.ToDecimal(n)));
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
            PlusMinus(n, arr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    public static void Staircase (int n, int level) {
        if (n > 0) {
            string display = "";
            for (int i = 0; i < n - 1; i++)
            {
                display = display + " ";
            }
            for (int j = 0; j < level; j++)
            {
                display = display + "#";
            }
            Console.WriteLine(display);
            Staircase(n - 1, level + 1);
        }
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Staircase(n, 1);
    }
}
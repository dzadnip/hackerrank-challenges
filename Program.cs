using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int MatchedItems(int n, int[] ar)
    {
        int[] matchedItems = Array.FindAll(ar, x => x == n);
        return matchedItems.Length;
    }

    public static int[] FindMissingNumbers (int[] aList, int [] bList, int aSize, int bSize)
    {
        List<int> missingNumbersList = new List<int>();

        for (int i = 0; i < bList.Length; i++)
        {
            if (MatchedItems(bList[i], aList) < MatchedItems(bList[i], bList))
            {
                if (!missingNumbersList.Contains(bList[i])) {
                    missingNumbersList.Add(bList[i]);
                }
            }
        }

        int[] missingNumbers = missingNumbersList.ToArray();
        return missingNumbers;
    }

    static void Main(String[] args)
    {
        //int aSize = Convert.ToInt32(Console.ReadLine());
        //int[] aList = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
        //int bSize = Convert.ToInt32(Console.ReadLine());
        //int[] bList = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();

        int aSize = 3;
        int bSize = 4;
        int[] aList = new int[] { 1, 2, 3, 4, 5 };
        int[] bList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 

        int[] missingNumbers = FindMissingNumbers(aList, bList, aSize, bSize);
        Array.Sort(missingNumbers);
        string printResults = String.Join(" ", missingNumbers);
        Console.WriteLine(printResults);
        Console.ReadLine();
    }
}
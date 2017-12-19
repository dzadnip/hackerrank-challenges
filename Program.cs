using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static int[] FindMissingNumbers (int[] aList, int [] bList, int aSize, int bSize)
    {
        List<int> missingNumbersList = new List<int>();
        Dictionary<int, int> aListDictionary = ConvertToDictionayAndCountInstances(aList);
        Dictionary<int, int> bListDictionary = ConvertToDictionayAndCountInstances(bList);
        for (int i = 0; i < bList.Length; i++)
        {
            if (aListDictionary.ContainsKey(bList[i]))
            {
                if (aListDictionary[bList[i]] < bListDictionary[bList[i]])
                {
                    if (!missingNumbersList.Contains(bList[i]))
                    {
                        missingNumbersList.Add(bList[i]);
                    }
                }
            } else
            {
                if (!missingNumbersList.Contains(bList[i]))
                {
                    missingNumbersList.Add(bList[i]);
                }
            }
        }
        int[] missingNumbers = missingNumbersList.ToArray();
        return missingNumbers;
    }


    public static Dictionary<int, int> ConvertToDictionayAndCountInstances (int[] arrList)
    {
        Dictionary<int, int> arr = new Dictionary<int, int>();
        foreach (int item in arrList)
        {
            try {
                arr.Add(item, 1);
            }
            catch {
                int count = arr[item];
                arr.Remove(item);
                arr.Add(item, count + 1);
            }
        }
        return arr;
    }

    static void Main(String[] args)
    {
        int aSize = Convert.ToInt32(Console.ReadLine());
        int[] aList = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
        int bSize = Convert.ToInt32(Console.ReadLine());
        int[] bList = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();

        int[] missingNumbers = FindMissingNumbers(aList, bList, aSize, bSize);
        Array.Sort(missingNumbers);
        string printResults = String.Join(" ", missingNumbers);
        Console.WriteLine(printResults);
        Console.ReadLine();
    }
}
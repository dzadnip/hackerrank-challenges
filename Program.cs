using System;

class Solution
{
    static string TimeConversion(string time)
    {
        // Complete this function
        DateTime dateValue;
        if (DateTime.TryParse(time, out dateValue))
        {
            return dateValue.ToString("HH:mm:ss");
        } else
        {
            return "";
        }
    }

    static void Main(String[] args)
    {
        Console.WriteLine(TimeConversion(Console.ReadLine()));
    }
}
/*
//  Author: Jonathan Scholl
//  Date: 12/28/2021
//  Project: https://www.hackerrank.com/challenges/birthday-cake-candles/problem?isFullScreen=true
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        int maxHeight = candles.Max();
        int candleCount = 0;

        for (int x = 0; x < candles.Count(); x++)
        {
            if (candles[x] == maxHeight) candleCount++;
        }
        return candleCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        Console.WriteLine(result);
    }
}

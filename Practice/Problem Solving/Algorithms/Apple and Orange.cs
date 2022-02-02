/*
//  Author: Jonathan Scholl
//  Date: 2/2/2022
//  Project: https://www.hackerrank.com/challenges/apple-and-orange/problem
*/
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        //variables
        int[] houseRange = new int[] {s, t};
        int appleTreePoint = a;
        int orangeTreePoint = b;
        int appleCount = apples.Count, orangeCount = oranges.Count;
        int appleHouseCount = 0, orangeHouseCount = 0;

        //calculations
        foreach (int apple in apples)
        {
            int distance = appleTreePoint + apple;
            if (distance >= houseRange[0] && distance <= houseRange[1])
            {
                appleHouseCount++;
            }
        }

        foreach (int orange in oranges)
        {
            int distance = orangeTreePoint + orange;
            if (distance >= houseRange[0] && distance <= houseRange[1])
            {
                orangeHouseCount++;
            }
        }

        //output results
        Console.WriteLine(appleHouseCount);
        Console.WriteLine(orangeHouseCount);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

         int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}

/*
//  Author: Jonathan Scholl
//  Date: 12/28/2021
//  Project: https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true&h_r=next-challenge&h_v=zen
*/
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime time = DateTime.Parse(s);

        return time.ToString("HH:mm:ss");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

    }
}

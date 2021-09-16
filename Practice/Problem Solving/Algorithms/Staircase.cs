/*
//  Author: Jonathan Scholl
//  Date: 9/15/2021
//  Project: Staircase
//  Description: 2 solutions for staircase algorithm
*/
using System;

class Solution
{
    public static void Main(string[] args)
    {
        //input number of steps
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircaseOptimal(n);
        Result.stairCaseSubOptimal(n);
    }
}
class Result
{
    //using 3 for loops for spacing, rows, columns
    public static void stairCaseSubOptimal(int n)
    {
        //store output and loop variables
        string output = "";
        int x, y, z;

        for (x = 1; x <= n; x++)
        {
            for (y = n - 1; y >= x; y--)
            {
                output += " ";
            }

            for (z = 1; z <= x; z++)
            {
                output += "#";
            }
            output += "\n";
        }
        Console.WriteLine(output);
    }

    //using string methods and 1 loop
    public static void staircaseOptimal(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }    
    }
}

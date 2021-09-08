/*
//  Author: Jonathan Scholl
//  Date: 9/8/2021
//  Exercise: Day 14 Scope
//  Description: Solution for Day 14 in C#
*/
using System;
using System.Linq;

class Difference
{
    // variables
    private int[] elements;
    public int maximumDifference;

    // constructor
    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    // public method to compute largest difference in numbers array
    public void computeDifference()
    {
        // stores max integer
        int maxNum = 0;

        // loops through every element based on length
        for (int x = 0; x < elements.Length; x++)
        {
            // loops through every element of the array based on length
            for (int y = 0; y < elements.Length; y++)
            {
                // absolute difference equals x - y
                int absolute = Math.Abs(elements[x] - elements[y]);
                // if absolute difference is greater than maxNum then it becomes the new max num.
                // Repeats until end of loop and highest number stored
                if (absolute > maxNum)
                {
                    maxNum = absolute;
                }
            }
        }
        //the max number from the loops are stored into maximumDifference
        maximumDifference = maxNum;
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        //convert input to integers
        Convert.ToInt32(Console.ReadLine());

        //store the input into an int array
        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        //creates instance of Difference Class
        Difference d = new Difference(a);

        //computes user input based off of the instance of the class
        d.computeDifference();

        //outputs the results to the user
        Console.Write(d.maximumDifference);
    }
}

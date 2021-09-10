/*
//  Author: Jonathan Scholl
//  Date: 9/10/2021
//  Exercise: Day 17 More Exceptions
//  Description: solution to day 17 hackerrank 30 days of code
*/
using System;

//calculator class
class Calculator
{
    //int method that takes 2 ints as paramaters
    public int power(int n, int p)
    {
        //if either input number is less than 0
        if (n < 0 || p < 0)
        {
            //throws exception to let user know numbers were negative
            throw new Exception("n and p should be non-negative");
        }
        //if both are positive, calculates n^p and returns value
        return (int)Math.Pow(n, p);
    }
}

class Solution
{
    static void Main(String[] args)
    {
        //creates object from calculator class
        Calculator myCalculator = new Calculator();

        //converts input into int Variable
        int T = Int32.Parse(Console.ReadLine());

        //while variable post decrement greater than 0
        while (T-- > 0)
        {
            //stores numbers into string array separate
            string[] num = Console.ReadLine().Split();

            //store first two elements in n and p variables
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                //runs power method of calculator class while passing user input numbers into method
                int ans = myCalculator.power(n, p);
                //outputs results if passes
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                //if exception is caught, outputs exception message
                Console.WriteLine(e.Message);
            }
        }
    }
}

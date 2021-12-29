/*
//  Author: Jonathan Scholl
//  Date: 12/28/2021
//  Project: https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true
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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> adjustedGrades = new List<int>();
        int firstDigit = 0, secondDigit = 0;
        string multiple = String.Empty;

        for (int x = 0; x < grades.Count; x++)
        {
            
            firstDigit = grades[x] / 10;
            secondDigit = grades[x] % 10;

            if (secondDigit < 5)
            {
                multiple += firstDigit.ToString() + "5";
            }
            else
            {
                multiple += (firstDigit + 1).ToString() + "0";
            }

            if (grades[x] < 38)
            {
                adjustedGrades.Add(grades[x]);
            }
            else if (int.Parse(multiple) - grades[x] < 3)
            {
                adjustedGrades.Add(int.Parse(multiple));
            }
            else
            {
                adjustedGrades.Add(grades[x]);
            }

            //reset string for next loop
            multiple = String.Empty;

        }

        return adjustedGrades;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));
    }
}

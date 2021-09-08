/*
//  Author: Jonathan Scholl
//  Date: 9/8/2021
//  Exercise: Day 12: Inheritance
//  Description: Day 12 of Hackerrank 30 days of Code
*/
using System;
using System.Linq;

class Person
{
	protected string firstName;
	protected string lastName;
	protected int id;

	public Person() { }
	public Person(string firstName, string lastName, int identification)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = identification;
	}
	public void printPerson()
	{
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
	}
}

class Student : Person
{
	private int[] scores;

	/*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */

	// Write your constructor here
	public Student(string firstName, string lastName, int identification, int[] testScores) : base(firstName, lastName, identification)
	{
		this.scores = testScores;
	}

	/*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
	// Write your method here
	public string Calculate()
    {
		int sumScores = 0;
		int numOfScores = 0;

		for (int i = 0; i < scores.Length; i++)
        {
			sumScores += scores[i];
			numOfScores++;
        }

		int grade = sumScores / numOfScores;

		if (grade >= 90 && grade <= 100)
        {
			return "O";
        }
		else if (grade >= 80 && grade < 90)
        {
			return "E";
        }
		else if (grade >=70 && grade < 80)
        {
			return "A";
		}
		else if (grade >= 55 && grade < 70)
		{
			return "P";
		}
		else if (grade >= 45 && grade < 55)
		{
			return "D";
		}
		return "T";


	}

}

class Solution
{
	static void Main()
	{
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
		string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
		int[] scores = new int[numScores];
		for (int i = 0; i < numScores; i++)
		{
			scores[i] = Convert.ToInt32(inputs[i]);
		}

		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}

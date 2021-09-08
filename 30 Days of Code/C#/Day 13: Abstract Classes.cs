/*
//  Author: Jonathan Scholl
//  Date: 9/8/2021
//  Exercise: Hackerrank 30 days of Coding Day 13
//  Description: Abstract classes
*/
using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    int price;

    public MyBook(string t, string a, int price) : base(t, a)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine("Title: " + title + "\nAuthor: " + author + "\nPrice: " + price);
    }
}
class Solution
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}

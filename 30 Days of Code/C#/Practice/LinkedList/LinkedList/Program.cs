/*
//  Author: Jonathan Scholl
//  Date: 9/8/2021
//  Exercise: Day 15 Hackerrank tutorial video
//  Description: Following blondiebytes video and translating it to C#
*/
using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {      
        
        public static void Main(string[] args)
        {
            LinkedList<string> linkedlist = new LinkedList<string>();
            linkedlist.AddFirst("Alice");
            Console.WriteLine(linkedlist);
            linkedlist.AddLast("Andy");
            Console.WriteLine(linkedlist);

            
        }
    }
}

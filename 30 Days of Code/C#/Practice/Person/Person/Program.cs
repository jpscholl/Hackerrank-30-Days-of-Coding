/*
//  Author: Jonathan Scholl
//  Date: 9/14/2021
//  Exercise: Pointers Day 20 tutorial video
//  Description: following along with tutorial video
*/
using System;

namespace Person
{
    class Program
    {
        public class Person
        {
            public HairColor hairColor = HairColor.Black;
        }

        public static void Main(string[] args)
        {
            Person peterParker = new Person();
            Person spiderMan = peterParker;

            Console.WriteLine("Before dying hair: " + peterParker.hairColor);

            peterParker.hairColor = HairColor.Pink;

            Console.WriteLine("After dying hair: ");
            Console.WriteLine("Hair color of Peter Parker: " + peterParker.hairColor);
            Console.WriteLine("Hair color of Spiderman: " + spiderMan.hairColor);


        }
    }
}

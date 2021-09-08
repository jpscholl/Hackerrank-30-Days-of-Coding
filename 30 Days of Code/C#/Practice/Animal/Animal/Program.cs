/*
//  Author: Jonathan Scholl
//  Date: 9/8/2021
//  Exercise: Hackerrank 30 Days of Code Day 12 Tutorial Video
//  Description: Program created from tutorial video, except my preference and C#
*/
using System;
using System.Linq;

namespace Animal
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog doggo = new Dog();
            Cat catto = new Cat(7);

            doggo.woof();
            Console.WriteLine("Dog's age: " + doggo.getAge());
            catto.meow();
            Console.WriteLine("Cat's age: " + catto.getAge());

            doggo.eat();
            catto.eat();

            doggo.run();
            catto.hunting();

            //what happens if...
            // Dog o = new Animal(3)
            //Animal o = new Dog();

        }
    }
}

/*
//  Author: Jonathan Scholl
//  Date: 9/10/2021
//  Exercise: Hot Chocolate
//  Description: 30 Days of code day 16 tutorial video
*/
using System;
using System.Threading;

namespace HotChocolate
{
    public class Program
    {
        public const double tooHot = 185;
        public const double tooCold = 160;

        public static void drinkHotChocolate(double drinkTemp) //throws TooHotException, TooColdException
        {
            if (drinkTemp >= tooHot)
            {
                throw new TooHotException();
            }
            else if (drinkTemp <= tooCold)
            {
                throw new TooColdException();
            }
        }
        public static void Main(string[] args)
        {
            double currentDrinkTemp = 0;
            bool wrongTemp = true;

            //prompt user and store temp
            Console.WriteLine("How hot is the hot chocolate in (F): ");
            currentDrinkTemp = Convert.ToDouble(Console.ReadLine());

            while (wrongTemp)
            {
                try
                {
                    drinkHotChocolate(currentDrinkTemp);
                    Console.WriteLine("Proper temp");
                    Console.WriteLine("That cocoa was good");
                    wrongTemp = false;
                }
                catch (TooHotException e1)
                {
                    Console.WriteLine("Too hot!");
                    currentDrinkTemp = currentDrinkTemp - 5;
                }
                catch (TooColdException e2)
                {
                    Console.WriteLine("Too cold!");
                    currentDrinkTemp = currentDrinkTemp + 5;
                }
                Thread.Sleep(2000);
            }
            Console.WriteLine("Finished the hot chocolate");
        }
    }
}

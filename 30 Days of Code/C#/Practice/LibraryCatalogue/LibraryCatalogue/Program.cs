/*
//  Author: Jonathan Scholl
//  Start Date: 9/6/2021 
//  Finished: 9/8/2021 v
//  Exercise: HackerRank day 11 practice
//  Description: Library Catalogue 
*/
using System;
using System.Collections.Generic;

namespace LibraryCatalogue
{
        public class Program
        {

            //main method
            static void Main(string[] args)
            {
                Dictionary<string, Book> bookCollection = new Dictionary<string, Book>();
                Book harry = new Book("Harry Potter", 234322, 9928389);
                bookCollection.Add("Harry Potter", harry);
                LibraryCatalogue lib = new LibraryCatalogue(bookCollection);

                lib.checkOutBook("Harry Potter");
                lib.nextDay();
                lib.nextDay();
                lib.checkOutBook("Harry Potter");
                lib.setDay(17);
                lib.returnBook("Harry Potter");
            }
        }
 }

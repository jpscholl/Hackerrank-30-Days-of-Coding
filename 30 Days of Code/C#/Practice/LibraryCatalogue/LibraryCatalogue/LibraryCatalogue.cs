using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogue
{
    public class LibraryCatalogue
    {
        // Properties/Fields/Global Variables
        Dictionary<String, Book> bookCollection = new Dictionary<string, Book>();
        int currentDay = 0;
        int lengthOfCheckoutPeriod = 7;
        double initialLateFee = 0.50;
        double feePerLateDay = 1.00;

        public LibraryCatalogue(Dictionary<string, Book> bookCollection)
        {
            this.bookCollection = bookCollection;
        }

        // Constructors
        public void Library_Catalogue(Dictionary<string, Book> collection)
        {
            this.bookCollection = collection;
        }

        public void Library_Catalogue(Dictionary<string, Book> collection, int lengthOfCheckoutPeriod,
            double initialLateFee, double feePerLateDay)
        {
            this.bookCollection = collection;
            this.lengthOfCheckoutPeriod = lengthOfCheckoutPeriod;
            this.initialLateFee = initialLateFee;
            this.feePerLateDay = feePerLateDay;
        }

        // Getters
        public int getCurrentDay()
        {
            return this.currentDay;
        }
        public Dictionary<string, Book> getBookCollection()
        {
            return this.bookCollection;
        }
        public Book getBook(string bookTitle)
        {
            return getBookCollection().GetValueOrDefault(bookTitle);
        }
        public int getLengthOfCheckoutPeriod()
        {
            return this.lengthOfCheckoutPeriod;
        }
        public double getInitialLateFee()
        {
            return this.initialLateFee;
        }
        public double getFeePerLateDay()
        {
            return this.feePerLateDay;
        }

        // Setters
        public void nextDay()
        {
            currentDay++;
        }
        public void setDay(int day)
        {
            currentDay = day;
        }

        // Instance methods:

        public void checkOutBook(string title)
        {
            Book book = getBook(title);
            if (book.getIsCheckedOut())
            {
                sorryBookAlreadyCheckedOut(book);
            }
            else
            {
                book.setIsCheckedOut(true, currentDay);
                Console.WriteLine("You just checked out " + title + ". It is due on day " +
                    (getCurrentDay() + getLengthOfCheckoutPeriod()) + ".");
            }
        }

        public void returnBook(string title)
        {
            Book book = getBook(title);
            int daysLate = currentDay - (book.getDayCheckedOut() + getLengthOfCheckoutPeriod());
            if (daysLate > 0)
            {
                Console.WriteLine("You owe the library $" + (getInitialLateFee() + daysLate * getFeePerLateDay()) +
                    " because your book is " + daysLate + " days overdue.");
            }
            else
            {
                Console.WriteLine("Book returned. Thank you.");
            }
            book.setIsCheckedOut(false, currentDay);
        }

        public void sorryBookAlreadyCheckedOut(Book book)
        {
            Console.WriteLine("Sorry, " + book.getTitle() + " is already checked out. "
                + "It should be back on day " + (book.getDayCheckedOut() +
                getLengthOfCheckoutPeriod()) + ".");
        }
    }
}

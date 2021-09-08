namespace LibraryCatalogue
{
    public class Book {
        //properties, fields, global variables
        string title;
        int pageCount;
        int ISBN;
        bool isCheckedOut; //whether or not book is checked out
        int dayCheckedOut = -1;

        //Constructors
        public Book(string bookTitle, int bookPageCount, int bookISBN) {
            this.title = bookTitle;
            this.pageCount = bookPageCount;
            this.ISBN = bookISBN;
            isCheckedOut = false;
        }

        //Getters ---> Instance Methods
        public string getTitle() {
            return this.title;
        }
        public int getPageCount() {
            return this.pageCount;
        }
        public int getISBN() {
            return this.ISBN;
        }
        public bool getIsCheckedOut() {
            return this.isCheckedOut;
        }
        public int getDayCheckedOut() {
            return this.dayCheckedOut;
        }

        //Setters
        public void setIsCheckedOut(bool newIsCheckedOut, int currentDayCheckOut) {
            this.isCheckedOut = newIsCheckedOut;
            setDayCheckedOut(currentDayCheckOut);
        }
        private void setDayCheckedOut(int day){
            this.dayCheckedOut = day;
        }
    }
}

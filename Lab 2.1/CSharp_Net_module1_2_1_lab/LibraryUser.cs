using System;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser

    interface ILibraryUser
    {
        void AddBook(string bookName);
        void RemoveBook(string bookName);
        string BookInfo(int index);
        int BooksCount();
    }


    // 2) declare class LibraryUser, it implements ILibraryUser

    class LibraryUser : ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)

        // 4) declare field (bookList) as a string array

        private string[] bookList;
        private int bookCount;

        public string FirstName { get; }
        public string LastName { get; }
        public int Id { get; }
        public string Phone { get; set; }
        public int BookLimit { get; }

        // 5) declare indexer BookList for array bookList

        public string this[int i]
        {
            get
            {
                return bookList[i];
            }
        }

        // 6) declare constructors: default and parameter

        public LibraryUser()
        {
            BookLimit = 1000;
            bookList = new string[BookLimit];
            FirstName = "Anonymous";
            LastName = "Anonymous";
            Id = 0;
            Phone = " ";
            bookCount = 0;
        }

        public LibraryUser(string firstName, string lastName, string phone, int id)
        {
            BookLimit = 1000;
            bookList = new string[BookLimit];
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Phone = phone;
            bookCount = 0;
        }

        // 7) declare methods: 
        //AddBook() – add new book to array bookList
        //RemoveBook() – remove book from array bookList
        //BookInfo() – returns book info by index
        //BooksCout() – returns current count of books

        public void AddBook(string bookName)
        {
            int i = 0;
            while (bookList[i] != null)
            {
                i++;
                if (i + 1 == BookLimit) return;

            }
            bookList[i] = bookName;
            bookCount++;
        }
        public void RemoveBook(string bookName)
        {
            int i = 0;
            while (bookList[i] != bookName)
            {
                i++;
                if (i + 1 == BookLimit) return;

            }
            bookList[i] = null;
            bookCount--;
        }
        public int BooksCount() { return bookCount; }
        public string BookInfo(int index) { return this[index]; }

    }



}

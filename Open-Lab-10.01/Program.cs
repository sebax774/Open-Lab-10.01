using System;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("The Return of the King",416);
            Console.ReadKey();
        }
    }
    class Book
    {
        public string title;
        int pages;
        public Book(string _title, int _pages)
        {
            title = _title;
            pages = _pages;
            Console.WriteLine(title + " has " + pages + " pages");
        }
    }
}
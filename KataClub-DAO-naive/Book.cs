using System;
using System.Collections.Generic;
using System.Linq;

namespace KataClub_DAO_naive
{
    public class Book
    {

        public int Isbn { get; set; }
        public String BookName { get; set; }

        public Book(int isbn, String bookName)
        {
            this.Isbn = isbn;
            this.BookName = bookName;
        }

        //list is working as a database
        private readonly List<Book> Books = new List<Book>
            {
                new Book(1, "Alice In Wonderland"),
                new Book(2, "Cinderella"),
                new Book(3, "The Three Little Bears")
            };
        

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBookByIsbn(int isbn)
        {
            return Books.Where(x => x.Isbn == isbn).FirstOrDefault();
        }

        public void SaveBook(Book book)
        {
            Books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            Books.Remove(book);
        }
    }
}

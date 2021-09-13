using System;
using System.Collections.Generic;
using System.Linq;

namespace KataClub_DAO
{
    public class BooksImpl : IBooks
    {

    //list is working as a database
    private List<Book> Books { get; set; }

    public BooksImpl()
    {
            Books = new List<Book>
            {
                new Book(1, "Alice In Wonderland"),
                new Book(2, "Cinderella"),
                new Book(3, "The Three Little Bears")
            };
        }

    public List<Book> GetAllBooks()
    {
        return Books;
    }

    public Book GetBookByIsbn(int isbn)
    {
        return Books.Where(x=>x.Isbn==isbn).FirstOrDefault();
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


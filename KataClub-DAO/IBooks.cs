using System;
using System.Collections.Generic;

namespace KataClub_DAO
{
    public interface IBooks
    {

        List<Book> GetAllBooks();
        Book GetBookByIsbn(int isbn);
        void SaveBook(Book book);
        void DeleteBook(Book book);

    }
}

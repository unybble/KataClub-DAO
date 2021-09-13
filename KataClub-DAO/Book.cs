using System;
namespace KataClub_DAO
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
    }
}

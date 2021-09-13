using System;
using System.Linq;

namespace KataClub_DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ibook = new BooksImpl();

            foreach (var b in ibook.GetAllBooks())
            {
                Console.WriteLine("Book ISBN : " + b.Isbn);
            }

            
            var book = ibook.GetAllBooks().FirstOrDefault();
            book.BookName="The Ugly Duckling";
            ibook.SaveBook(book);
        }
    }
}

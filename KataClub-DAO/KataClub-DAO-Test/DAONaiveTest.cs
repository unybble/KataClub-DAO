using System.Collections.Generic;
using KataClub_DAO_naive;
using NUnit.Framework;

namespace KataClub_DAO_Test
{
    public class Tests
    {
        [Test]
        public void ReturnsNonEmptyListOfBooks()
        {
            var books = new List<Book>();

            Assert.IsNotEmpty(books);
        }

        //create new method that returns author name
        //instead of connecting to https://isbndb.com/ instead of fake datastore
    }
}

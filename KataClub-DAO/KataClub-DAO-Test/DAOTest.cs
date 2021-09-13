using System.Collections.Generic;
using NUnit.Framework;
using KataClub_DAO;

namespace KataClub_DAO_Test
{
    public class DAONaiveTests
    {
        

        [Test]
        public void ReturnsNonEmptyListOfBooks()
        {
            var books = new List<Book>();

            Assert.IsNotEmpty(books);
        }
    }
}

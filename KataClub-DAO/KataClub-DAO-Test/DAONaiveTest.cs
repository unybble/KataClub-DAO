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
    }
}

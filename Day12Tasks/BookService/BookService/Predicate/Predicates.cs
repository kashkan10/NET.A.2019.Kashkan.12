using BookService.BookSystem;

namespace BookService.Predicate
{
    public class TitleTag : IPredicate
    {
        /// <summary>
        /// name
        /// </summary>
        private string title;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public TitleTag(string title)
        {
            this.title = title;
        }

        /// <summary>
        /// Checking for a match
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Result of check</returns>
        public bool IsMatch(Book book)
        {
            return book.Title == title;
        }
    }

    public class YearTag : IPredicate
    {
        /// <summary>
        /// year
        /// </summary>
        private int year;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="year"></param>
        public YearTag(int year)
        {
            this.year = year;
        }

        /// <summary>
        /// Checking for a match
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Result of check</returns>
        public bool IsMatch(Book book)
        {
            return book.Year == year;
        }
    }

    public class AuthorTag : IPredicate
    {
        /// <summary>
        /// author
        /// </summary>
        private string author;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="author"></param>
        public AuthorTag(string author)
        {
            this.author = author;
        }

        /// <summary>
        /// Checking for a match
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Result of check</returns>
        public bool IsMatch(Book book)
        {
            return book.Author == author;
        }
    }
}

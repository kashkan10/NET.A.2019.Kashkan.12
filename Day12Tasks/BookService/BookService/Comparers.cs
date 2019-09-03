using System;
using System.Collections.Generic;
using BookService.BookSystem;

namespace BookService
{
    internal class NameComparer : IComparer<Book>
    {
        /// <summary>
        /// IComparer<Book> implementation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Comprasion result</returns>
        public int Compare(Book a, Book b)
        {
            return string.Compare(a.Title, b.Title);
        }
    }

    internal class AuthorComparer : IComparer<Book>
    {
        /// <summary>
        /// IComparer<Book> implementation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Comprasion result</returns>
        public int Compare(Book a, Book b)
        {
            return string.Compare(a.Author, b.Author);
        }
    }

    internal class YearComparer : IComparer<Book>
    {
        /// <summary>
        /// IComparer<Book> implementation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Comprasion result</returns>
        public int Compare(Book a, Book b)
        {
            if (a.Year < b.Year)
            {
                return 1;
            }

            if (a.Year > b.Year)
            {
                return -1;
            }

            return 0;
        }
    }
}

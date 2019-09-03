using BookService.BookSystem;

namespace BookService.Predicate
{
    public interface IPredicate
    {
        bool IsMatch(Book book);
    }
}

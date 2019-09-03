using System.Collections.Generic;
using BookService.BookSystem;

namespace BookService.Storage
{
    public interface IStorage
    {
        string Path { get; set; }

        void Write(List<Book> list);

        void Load(List<Book> list);
    }
}

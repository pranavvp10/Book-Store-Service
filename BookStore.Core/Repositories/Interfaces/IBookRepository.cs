using BookStore.Core.Entities;

namespace BookStore.Core.Repositories.Interfaces
{
    public interface IBookRepository
    {
        Book GetBook(string Id);
        List<Book> GetAllBooks();

        void AddBook(Book book);
    }
}

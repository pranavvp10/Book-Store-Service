using BookStore.Core.Entities;

namespace BookStore.Service
{
    public interface IBookStoreService
    {
        Book GetBook(string Id);
        List<Book> GetAllBooks();

        void AddBook(Book book);
    }
}

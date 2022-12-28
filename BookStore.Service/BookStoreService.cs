using BookStore.Core.Entities;
using BookStore.Core.Repositories.Interfaces;

namespace BookStore.Service
{
    public class BookStoreService : IBookStoreService
    {
        private readonly IBookRepository _repository;
        public BookStoreService(IBookRepository bookStoreRepository)
        {
            _repository = bookStoreRepository;
        }
        public void AddBook(Book book)
        {
            try
            {
                _repository.AddBook(book);

            }
            catch (Exception exception)
            {

                Console.WriteLine($"Error Occured while adding book, Message: {exception.Message}");
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            try
            {
                books= _repository.GetAllBooks();
            }
            catch (Exception exception)
            {

                Console.WriteLine($"Error Occured while reading all book details, Message: {exception.Message}");
            }
            return books;
        }

        public Book? GetBook(string Id)
        {
            Book book = new Book();
            try
            {
                book = _repository.GetBook(Id);
            }
            catch (Exception exception)
            {

                Console.WriteLine($"Error Occured while reading book details of book id {Id}, Message: {exception.Message}");
            }
            return book;
        }
    }
}
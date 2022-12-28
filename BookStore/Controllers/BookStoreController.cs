using BookStore.Core.Entities;
using BookStore.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        private readonly IBookStoreService _bookStoreService;
        public BookStoreController(IBookStoreService bookStoreService)
        {
            _bookStoreService = bookStoreService;
        }

        /// <summary>
        /// API endpoint for adding a book to list
        /// </summary>
        /// <param name="book">An object of book consisting Id, Name and Author Name.</param>
        [HttpPost]
        [Route("/book")]
        public void AddBook(Book book)
        {
            _bookStoreService.AddBook(book);
        }

        /// <summary>
        /// API endpoint to get details of all books.
        /// </summary>
        /// <returns> A List of Book Details</returns>
        [HttpGet]
        [Route("/books/all")]
        public List<Book> GetAllBooks()
        {
            return _bookStoreService.GetAllBooks();
        }


        /// <summary>
        /// API endpoint to fetch details of a particular book by its Id.
        /// </summary>
        /// <param name="id">Id of the book to fetch</param>
        /// <returns>A book object</returns>
        [HttpGet]
        [Route("/book")]
        public Book GetBook(string id)
        {
            return _bookStoreService.GetBook(id);
        }
    }
}

using BookStore.Core.Entities;
using BookStore.Service;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        [Route("/book")]
        public void AddBook(Book book)
        {
            _bookStoreService.AddBook(book);
        }

        [HttpGet]
        [Route("/books/all")]
        public List<Book> GetAllBooks()
        {
            return _bookStoreService.GetAllBooks();
        }

        [HttpGet]
        [Route("/book")]
        public Book GetBook(string id)
        {
            return _bookStoreService.GetBook(id);
        }
    }
}

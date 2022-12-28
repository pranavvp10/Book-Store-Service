using BookStore.Core.Contexts;
using BookStore.Core.Entities;
using BookStore.Core.Repositories.Interfaces;

namespace BookStore.Core.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookStoreDBContext _bookStoreDBContext;
        private List<Book> dummyBookList = new List<Book>();
        public BookRepository(BookStoreDBContext bookStoreDBContext)
        {
            _bookStoreDBContext = bookStoreDBContext;
            //dummyBookList = new List<Book>() 
            //{
            //    new Book() { Id = "123" , Name = "abc", AuthorName = "xyz"},
            //    new Book() { Id = "324" ,Name = "efg", AuthorName = "pqr" }
            //};   
        }

        public void AddBook(Book book)
        {
            //_bookStoreDBContext.Books.Add(book);
            //_bookStoreDBContext.SaveChanges();
            dummyBookList.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return _bookStoreDBContext.Books.ToList();
            //return dummyBookList;
        }

        public Book GetBook(string Id)
        {
            return _bookStoreDBContext.Books == null ? new Book() : _bookStoreDBContext.Books.Where(x => x.Id == Id).FirstOrDefault();
            //return dummyBookList.Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}

using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public interface IBookStoreService
    {
        Book GetBook(string Id);
        List<Book> GetAllBooks();

        void AddBook(Book book);
    }
}

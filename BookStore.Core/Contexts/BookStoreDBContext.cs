using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Core.Contexts
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

    }
}

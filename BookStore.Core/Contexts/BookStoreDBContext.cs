using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Contexts
{
    public class BookStoreDBContext: DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options):base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

    }
}

using Lab2.Lab6;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Context
{
    public class LibraryContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }


        public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
        { }
    }
}

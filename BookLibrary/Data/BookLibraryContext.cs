using BookLibrary.Models.Domain;
using System.Data.Entity;

namespace BookLibrary.Data
{
    class BookLibraryContext : DbContext
    {
        public BookLibraryContext() : base("DefaultConnection")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Ganre> Ganres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BookLibraryContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
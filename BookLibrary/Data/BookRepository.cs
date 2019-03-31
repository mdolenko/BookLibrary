using BookLibrary.Data.Interfaces;
using BookLibrary.Models;
using BookLibrary.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary.Data
{
    public class BookRepository : IDisposable, IRepository
    {
        private BookLibraryContext db = new BookLibraryContext();

        public void Save(Book b)
        {
            db.Books.Add(b);
            db.SaveChanges();
        }
        public IEnumerable<Book> List()
        {
            return db.Books.ToList();
        }
        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
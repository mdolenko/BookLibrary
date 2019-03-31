using BookLibrary.Models.Domain;
using System.Collections.Generic;

namespace BookLibrary.Data.Interfaces
{
    public interface IRepository
    {
        void Save(Book b);
        IEnumerable<Book> List();
        Book Get(int id);
    }
}

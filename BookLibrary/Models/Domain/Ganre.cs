using System.Collections.Generic;

namespace BookLibrary.Models.Domain
{
    public class Ganre
    {
        public int GanreId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
namespace BookLibrary.Models.Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int CopiesCount { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int GanreId { get; set; }
        public virtual Ganre Ganre { get; set; }
    }
}
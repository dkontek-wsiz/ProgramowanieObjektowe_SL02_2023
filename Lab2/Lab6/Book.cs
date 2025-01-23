using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class Book : IEntity<int>, ICreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }

        public List<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();
    }    
}

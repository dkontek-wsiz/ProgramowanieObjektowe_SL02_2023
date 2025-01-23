using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class BorrowedBook : IEntity<long>, ICreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public int BookId { get; set; }
        public Book Book { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
    }
}

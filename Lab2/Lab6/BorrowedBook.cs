using Lab2.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2.Lab6
{
    [Table("Boorowedbooks2")]
    public class BorrowedBook : IEntity<long>, ICreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
    }
}

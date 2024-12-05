using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class Book : IEntity<int>, ICreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
    }    
}

using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class Person : IEntity<long>, ICreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

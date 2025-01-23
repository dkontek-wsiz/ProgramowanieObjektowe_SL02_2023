﻿using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class Person : IEntity<long>, ICreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<BorrowedBook> BorrowedBooks { get; set; } = new List<BorrowedBook>();

        public Person()
        {
            CreationTime = DateTime.Now;
        }
    }
}

﻿using Lab2.Lab6;

namespace Lab2.Interfaces
{
    public interface IBookRepository
        : IBaseRepository<Book, int>
    {

        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByPublishYear(int year);
    }
}

﻿using Lab2.Interfaces;
using Lab2.Lab6;
using WebApplication1.Context;

namespace WebApplication1.Repostories
{
    public class EFBookRepository(LibraryContext context) : IBookRepository
    {
        public void Create(Book entity)
        {
            context.Books.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Books.Remove(context.Books.Find(id));
            context.SaveChanges();
        }

        public Book Get(int id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return context.Books.Where(x => x.Author == author).ToList();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}

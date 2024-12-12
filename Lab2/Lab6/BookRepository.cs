﻿using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class BookRepository : IBookRepository
    {
        private List<Book> data = new()
        {
           new Book
           {
               Id = 1,
               CreationTime = DateTime.Now,
               Title = "Potop"
           }
        };

        public void Create(Book entity)
        {
            entity.Id = data.Count + 1;
            data.Add(entity);
        }

        public void Delete(int id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public Book Get(int id)
        {
            return data.Find(x => x.Id == id);
        }

        public List<Book> GetAll()
        {
            return data;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return data.Where(x => x.Author == author).ToList();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            return data.Where(x => x.PublishDate.Year == year).ToList();
        }

        public void Update(Book entity)
        {
            var index = data.FindIndex(x => x.Id == entity.Id);
            if (index > -1)
                data[index] = entity;
        }
    }
}

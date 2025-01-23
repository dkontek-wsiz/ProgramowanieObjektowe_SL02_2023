using Lab2.Interfaces;
using Lab2.Lab6;
using System.Text.Json;

namespace WebApplication1.Repostories
{
    public class FileBookRepository : IBookRepository
    {
        private readonly string _fileName = "books.json";

        private List<Book> ReadFile()
        {
            if (File.Exists(_fileName))
            {
                var content = File.ReadAllText(_fileName);

                return JsonSerializer.Deserialize<List<Book>>(content);
            }
            return new List<Book>();
        }

        private void WriteFile(List<Book> data)
        {
            var content = JsonSerializer.Serialize(data);

            File.WriteAllText(_fileName, content);
        }

        public void Create(Book entity)
        {
            var books = ReadFile();

            entity.Id = books.Count + 1;
            books.Add(entity);
            WriteFile(books);
        }

        public List<Book> GetAll()
        {
            return ReadFile();
        }

        public void Delete(int id)
        {
            var books = ReadFile();

            books.RemoveAll(x => x.Id == id);

            WriteFile(books);
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            throw new NotImplementedException();
        }


        public void Update(Book entity)
        {
            var books = ReadFile();

            var index = books.FindIndex(x => x.Id == entity.Id);
            if (index > -1)
            {
                books[index] = entity;
                WriteFile(books);
            }
        }
    }
}

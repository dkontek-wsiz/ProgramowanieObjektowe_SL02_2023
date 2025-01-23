using Lab2.Interfaces;
using Lab2.Lab6;
using System.Data.SQLite;

namespace WebApplication1.Repostories
{
    public class ADONETBookRepository(IConfiguration configuration) : IBookRepository
    {
        private readonly string connectionString = configuration.GetConnectionString("DefaultConnection");
        public void Create(Book entity)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = @"INSERT INTO Books (CreationTime, Title, Author, PublishDate)
 VALUES (@CreationTime, @Title, @Author, @PublishDate)";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@CreationTime", entity.CreationTime);
            command.Parameters.AddWithValue("@Title", entity.Title);
            command.Parameters.AddWithValue("@Author", entity.Author);
            command.Parameters.AddWithValue("@PublishDate", entity.PublishDate);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            var books = new List<Book>();
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = @"SELECT * FROM Books";
            using var command = new SQLiteCommand(query, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CreationTime = Convert.ToDateTime(reader["CreationTime"]),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    PublishDate = Convert.ToDateTime(reader["PublishDate"])
                });
            }
            return books;
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
            throw new NotImplementedException();
        }
    }
}

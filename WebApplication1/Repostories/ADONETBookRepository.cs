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

        public Book Get(int id)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Books WHERE Id = @Id";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Book
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    CreationTime = Convert.ToDateTime(reader["CreationTime"]),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    PublishDate = Convert.ToDateTime(reader["PublishDate"])
                };
            }
            return null;
        }


        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM Books WHERE Id = @Id";
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
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

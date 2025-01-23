using System.Data.SQLite;

namespace WebApplication1.Utilites
{
    public static class DbCreator
    {
        public static void CreateTable(string connectionString)
        {
            using SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            // SQL polecenie do tworzenia tabel
            string createTablesCommand = @"
 CREATE TABLE IF NOT EXISTS Books (
 Id INTEGER PRIMARY KEY,
 CreationTime DATETIME NOT NULL,
 Title TEXT NOT NULL,
 Author TEXT NOT NULL,
 PublishDateDATETIME NOT NULL
 );
 CREATE TABLE IF NOT EXISTS Persons (
 Id INTEGER PRIMARY KEY,
 CreationTime DATETIME NOT NULL,
 FirstName TEXT NOT NULL,
 LastName TEXT NOT NULL,
 Age INTEGER NOT NULL
 );
 CREATE TABLE IF NOT EXISTS BorrowedBooks (
 Id INTEGER PRIMARY KEY,
 CreationTime DATETIME NOT NULL,
 BookId INTEGER NOT NULL,
 PersonId INTEGER NOT NULL,
 FOREIGN KEY (BookId) REFERENCES Books(Id),
 FOREIGN KEY (PersonId) REFERENCES Persons(Id)
 );
 ";
            using (SQLiteCommand command = new(createTablesCommand, connection))
            {
                command.ExecuteNonQuery();
            }
            Console.WriteLine("Tabele zostały utworzone!");
        }
    }
}
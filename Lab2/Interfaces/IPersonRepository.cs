using Lab2.Lab6;

namespace Lab2.Interfaces
{
    public interface IPersonRepository: IBaseRepository<Person, long>
    {
        List<Book> GetBorrowedBook(long id);
        void BorrowBook(long id, Book book);
    }
}

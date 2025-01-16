using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab2.Lab6;
using Lab2.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController(IBookRepository repository) : ControllerBase
    {

        [HttpGet]
        public List<Book> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet]
        public ActionResult<Book> Get(int id)
        {
            return Ok(repository.Get(id));
        }


        [HttpPost]
        public void Create(Book value)
        {
            repository.Create(value);
        }

        [HttpPut]
        public void Update(Book value)
        {
            repository.Update(value);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpGet]
        public List<Book> GetBookByAuthors(string author)
        {
            return repository.GetBooksByAuthor(author);
        }

        [HttpGet]
        public List<Book> GetByYear(int year)
        {
            return repository.GetBooksByPublishYear(year);
        }
    }
}

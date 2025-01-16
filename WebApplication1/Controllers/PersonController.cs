using Lab2.Interfaces;
using Lab2.Lab6;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repository;

        public PersonController(IPersonRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public List<Person> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet]
        public ActionResult<Person> Get(int id)
        {
            return Ok(_repository.Get(id));
        }

        [HttpPost]
        public void Create(Person value)
        {
            _repository.Create(value);
        }

        [HttpPut]
        public void Update(Person value)
        {
            _repository.Update(value);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        [HttpGet]
        public List<Book> GetBoorowedBooks(int id)
        {
            return _repository.GetBorrowedBook(id);
        }

        [HttpPost]

        public void BorrwBook(int id, Book book)
        {
            _repository.BorrowBook(id, book);
        }
    }
}

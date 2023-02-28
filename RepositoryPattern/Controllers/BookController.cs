using BusniessLogicLayer.IRepository;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IGenericRepository<Book> BookRepository;

        public BookController(IGenericRepository<Book> BookRepository)
        {
            this.BookRepository = BookRepository;
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(BookRepository.GetById(id));
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await BookRepository.GetByIdAsync(id));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(BookRepository.GetAll());
        }


        [HttpGet("GetName")]
        public IActionResult GetName(string title)
        {
            return Ok(BookRepository.Find(b => b.Title == title));
        }
    }
}


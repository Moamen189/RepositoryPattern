using BusniessLogicLayer.IRepository;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IGenericRepository<Author> authorRepository;

        public AuthorController(IGenericRepository<Author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(authorRepository.GetById(id));
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult>  GetByIdAsync(int id)
        {
            return Ok(await authorRepository.GetByIdAsync(id));
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok( authorRepository.GetAll());
        }

        [HttpGet("GetName")]
        public IActionResult GetName(string name)
        {
            return Ok(authorRepository.Find(b => b.Name == name));
        }
    }
}

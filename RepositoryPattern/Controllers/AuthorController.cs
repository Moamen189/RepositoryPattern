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
    }
}

using BusniessLogicLayer.IRepository;
using DataAccessLayer.Models;

namespace RepositoryPattern.Controllers
{
    public class AuthorsController
    {
        private readonly IGenericRepository<Author> authorRepository;

        public AuthorsController(IGenericRepository<Author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }
    }
}

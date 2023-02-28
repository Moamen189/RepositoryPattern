using BusniessLogicLayer.IRepository;
using DataAccessLayer.Models;

namespace RepositoryPattern.Controllers
{
    public class AuthorsController
    {
        private readonly IGenericRepository<Author> genericRepository;

        public AuthorsController(IGenericRepository<Author> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
    }
}

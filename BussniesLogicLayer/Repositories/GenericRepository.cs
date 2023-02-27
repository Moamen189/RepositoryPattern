using BussniesLogicLayer.Interfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniesLogicLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public T GetById(int id)
        {
            return context?.Set<T>()?.Find(id);
        }
    }
}

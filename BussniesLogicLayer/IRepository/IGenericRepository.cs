﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussniesLogicLayer.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
    }
}

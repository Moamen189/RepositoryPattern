﻿using BusniessLogicLayer.IRepository;
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
    }
}

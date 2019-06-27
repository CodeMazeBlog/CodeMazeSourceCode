using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithFilters.Filters;
using WorkingWithFilters.Models;

namespace WorkingWithFilters.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [ValidateModel]
        [HttpPost]
        public IActionResult Create([FromBody]Book book)
        {
            return View();
        }

    }
}
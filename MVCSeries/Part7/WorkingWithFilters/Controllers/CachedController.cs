using Microsoft.AspNetCore.Mvc;
using System;
using WorkingWithFilters.Filters;

namespace WorkingWithFilters.Controllers
{
    [CacheResource]
    public class CachedController : Controller
    {
        public IActionResult Index()
        {
            return Content("This content was generated at " + DateTime.Now);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;

namespace WorkingWithFilters.Filters
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute(string permission)
           : base(typeof(AuthorizeActionFilter))
        {
            Arguments = new object[] { permission };
        }
    }
}

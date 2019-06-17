using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace WorkingWithFilters.Filters
{
    public class AddHeaderFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(
                "OnResultExecuting",
                "This header was added by result filter.");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}

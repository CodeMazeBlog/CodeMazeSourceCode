using Microsoft.AspNetCore.Mvc;

namespace WorkingWithFilters.Filters
{
    public class CacheResourceAttribute : TypeFilterAttribute
    {
        public CacheResourceAttribute()
            : base(typeof(CacheResourceFilter))
        {
        }
    }
}

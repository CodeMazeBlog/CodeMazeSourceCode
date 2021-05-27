using Microsoft.AspNetCore.Mvc;

namespace WorkingWithFilters.Filters
{
    public class AddHeaderAttribute : TypeFilterAttribute
    {
        public AddHeaderAttribute() : base(typeof(AddHeaderFilter))
        {
        }
    }
}

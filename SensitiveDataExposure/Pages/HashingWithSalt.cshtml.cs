using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OWASPTop10.Models;

namespace OWASPTop10.Pages
{
    public class HashingWithSaltModel : PageModel
    {
        [BindProperty]
        public UserSecret UserSecret { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostAsync()
        {
            return RedirectToPage("./HashingWithSaltResult", new
            {
                secretValue = UserSecret.SecretValue
            });
        }
    }
}
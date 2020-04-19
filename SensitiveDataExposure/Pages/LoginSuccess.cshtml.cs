using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace OWASPTop10.Pages
{
    [ResponseCache(Duration = 60)]
    public class LoginSuccessModel : PageModel
    {
        public string Username { get; set; }

        public string CurrentTime { get; set; }

        public void OnGet(string username)
        {
            Username = username;
            CurrentTime = DateTime.Now.ToLongTimeString();
        }
    }
}
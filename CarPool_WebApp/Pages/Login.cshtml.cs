using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarPool_WebApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginInputModel Input { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Perform login logic here
            // ...

            return RedirectToPage("/Index");
        }
        public class LoginInputModel
        {
            [Required]
            public string Username { get; set; }

            [Required]
            public string Password { get; set; }
        }
    }
}


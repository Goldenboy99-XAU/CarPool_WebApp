using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarPool_WebApp.Pages
{
    public class RegisterModel : PageModel
    {
        public string Email { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Surname { get; set; }

        [BindProperty]
        public string Mobile { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string ConfrimPassword { get; set; }
        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            // Validate the form data here
            if (string.IsNullOrEmpty(Email))
            {
                ModelState.AddModelError("Email", "Email is required.");
            }

            if (string.IsNullOrEmpty(Name))
            {
                ModelState.AddModelError("name", "Name is required.");
            }

            if (string.IsNullOrEmpty(Surname))
            {
                ModelState.AddModelError("Surname", "Surname is required.");
            }

            if (string.IsNullOrEmpty(Mobile))
            {
                ModelState.AddModelError("Mobile", "Mobile is required.");
            }

            if (string.IsNullOrEmpty(Password))
            {
                ModelState.AddModelError("Password", "Password is required.");
            }

            if (Password != ConfrimPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "Passwords do not match.");
            }

            if (!ModelState.IsValid)
            {
                return;
            }

            // Save the user registration data here, such as to a database
        }
    }
}

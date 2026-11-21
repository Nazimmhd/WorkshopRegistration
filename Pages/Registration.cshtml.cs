
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkshopRegistration.Models;

namespace WorkshopRegistration.Pages
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public Registration Registration { get; set; } = new();

        public bool IsSubmitted { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            IsSubmitted = true;
            return Page();
        }
    }
}

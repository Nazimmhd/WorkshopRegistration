
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkshopRegistration.Models;
using WorkshopRegistration.Services;

namespace WorkshopRegistration.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly RegistrationFileService _fileService;

        public RegistrationModel(
            RegistrationFileService fileService)
        {
            _fileService = fileService;
        }

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

            _fileService.SaveRegistration(Registration);

            IsSubmitted = true;

            return Page();
        }
    }
}

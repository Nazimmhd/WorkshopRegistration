
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkshopRegistration.Models;
using WorkshopRegistration.Services;

namespace WorkshopRegistration.Pages
{
    public class RegistrationsModel : PageModel
    {
        private readonly RegistrationFileService _fileService;

        public RegistrationsModel(
            RegistrationFileService fileService)
        {
            _fileService = fileService;
        }

        public List<Registration> Registrations { get; set; } = new();

        public void OnGet()
        {
            Registrations = _fileService.GetRegistrations();
        }
    }
}

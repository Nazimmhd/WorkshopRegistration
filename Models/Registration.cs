using System.ComponentModel.DataAnnotations;
namespace WorkshopRegistration.Models;

public class Registration
{
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(50, MinimumLength = 2, 
    ErrorMessage = "First name must be between 2 and 50 characters.")]
    public string FirstName { get; set; }="";

    [Range(16, 120, ErrorMessage = "Age must be between 16 and 120.")]
    public int Age { get; set; }    
    
}
using System.ComponentModel.DataAnnotations;
namespace WorkshopRegistration.Models{

public class Registration
{
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(50, MinimumLength = 2, 
    ErrorMessage = "First name must be between 2 and 50 characters.")]
    public string FirstName { get; set; }="";

    [Range(16, 100, ErrorMessage = "Age must be between 16 and 100.")]
    public int Age { get; set; }    

    [Required(ErrorMessage ="please select a workshop")]
    public String Workshop{get;set;}="";

    public bool RequiresLaptop{get;set;}

    
} }
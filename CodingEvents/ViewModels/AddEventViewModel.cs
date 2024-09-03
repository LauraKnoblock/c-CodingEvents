using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Name of event is required.")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Event name should be between 3-50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Event description is required.")]
        [StringLength(500, ErrorMessage ="Description is over 500 characters.")]
        public string? Description { get; set; }

        [EmailAddress]
        public string? ContactEmail { get; set; }
    }
}

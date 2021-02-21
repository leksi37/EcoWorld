using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcoFriendly.Models
{
    public class Credentials
    {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)", ErrorMessage = "Invalid email")]
        [EmailAddress]
        public string Email { set; get; }

        [StringLength(50, ErrorMessage = "Password cannot be longer than 50 characters.")]
        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}

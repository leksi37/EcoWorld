using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace EcoFriendly.Models
{ 
    [Serializable]
    public class Organization
    {
        [Key]
        public int OrgID { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)", ErrorMessage = "Invalid email")]
        [EmailAddress]
        public string Email { set; get; }

        [StringLength(50, ErrorMessage = "Password cannot be longer than 50 characters.")]
        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Organization name is required")]
        [DisplayName("Organization name")]
        [StringLength(50, ErrorMessage = "Organization name cannot be longer than 50 characters.")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Location is required")]
        [DisplayName("Location")]
        public string Location { set; get; }

        [DisplayName("Description")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { set; get; }
    }
}

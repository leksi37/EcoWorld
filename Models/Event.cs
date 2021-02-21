using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoFriendly.Models
{
    [Serializable]
    public class Event
    {
        [Key]
        public int EventID { set;  get; }

        [Required(ErrorMessage = "Event name is required")]
        [DisplayName("Event name")]
        [StringLength(50, ErrorMessage = "Organization name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Time is required")]
        [DisplayName("Event time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dddd, dd MMMM yyyy HH:mm:ss", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [DisplayName("Event location")]
        public string Location { get; set; }

        public Organization OrgID { get; set; }

        [DisplayName("Event description")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }
    }
}

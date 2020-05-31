using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "Name must contain at least 4 characters")]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [MaxLength(200, ErrorMessage = "Too Long")]
        [Required]
        public string Message { get; set; }
    }
}

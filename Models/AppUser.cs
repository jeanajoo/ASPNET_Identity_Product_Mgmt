using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Joo_Jeana_HW4.Models
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }
    }
}
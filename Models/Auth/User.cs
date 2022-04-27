using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace dnd.Models.Auth
{
    public class User : IdentityUser  // All of the Identity User properties are inherited automatically
    {
        // Additional properties to be included in each user object
        [Required]
        [StringLength(55)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(55)]
        public string LastName { get; set; }

    }
}

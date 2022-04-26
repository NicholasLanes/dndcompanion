using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace dnd.Models.Auth
{
    public class Login
    {
        [Required(ErrorMessage = "Username field is required. Please enter a username.")]
        [StringLength(255, ErrorMessage = "Username length cannot be greater than 255 characters. Please keep usernames below 255 characters. ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password field is required. Please enter a password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = false; 

    }
}

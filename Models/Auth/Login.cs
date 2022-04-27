using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace dnd.Models.Auth
{
    // Login object is nothing fancy. Just stores a value for username, password, and rememberMe to be queried
    public class Login
    {
        // UserName
        [Required(ErrorMessage = "Username field is required. Please enter a username.")]
        [StringLength(255, ErrorMessage = "Username length cannot be greater than 255 characters. " +
            "Please keep usernames below 255 characters. ")]
        public string UserName { get; set; }

        // Password
        [Required(ErrorMessage = "Password field is required. Please enter a password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Remember Me (Defaults to false)
        public bool RememberMe { get; set; } = false; 

    }
}

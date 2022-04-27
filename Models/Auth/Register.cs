using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace dnd.Models.Auth
{
    // Reference this for creating and registering a new user identity
    public class Register
    {
        // First Name
        [Required(ErrorMessage="First Name field is required. Please enter a first name.")]
        [StringLength(55, ErrorMessage = "First name length cannot be greater than 55 characters. Please restrict first name to 55 characters. Try a nickname?")]
        public string FirstName { get; set; }

        // Last Name
        [Required(ErrorMessage = "Last Name field is required. Please enter a last name.")]
        [StringLength(55, ErrorMessage ="Last name length cannot be greater than 55 characters. Please restrict last name to 55 characters. Try a nickname?")]
        public string LastName { get; set; }

        // UserName
        [Required(ErrorMessage = "Username field is required. Please enter a username.")]
        [StringLength(255, ErrorMessage = "Username length cannot be greater than 255 characters. Please keep usernames below 255 characters. ")]
        public string UserName { get; set; }

        // Password
        [Required(ErrorMessage = "Password field is required. Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        // Password to be Compared
        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        // Email
        [Required(ErrorMessage = "Email address field is required. Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        [Compare("ConfirmEmail")]
        public string Email { get; set; }

        // Email to be Compared
        [Required(ErrorMessage = "Please confirm your email address.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        // Phone Number
        [Required(ErrorMessage = "Phone number field is required. Please enter a phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Compare("PhoneNumberConfirmed")]
        public string PhoneNumber { get; set; }

        // Phone Number to be Compared
        [Required(ErrorMessage = "Please confirm your phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Confirm Phone")]
        public string PhoneNumberConfirmed { get; set;}
    }
}

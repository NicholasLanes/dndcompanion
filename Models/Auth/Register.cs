using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace dnd.Models.Auth
{
    public class Register
    {
        [Required(ErrorMessage="First Name field is required. Please enter a first name.")]
        [StringLength(55, ErrorMessage = "First name length cannot be greater than 55 characters. Please restrict first name to 55 characters. Try a nickname?")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name field is required. Please enter a last name.")]
        [StringLength(55, ErrorMessage ="Last name length cannot be greater than 55 characters. Please restrict last name to 55 characters. Try a nickname?")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Username field is required. Please enter a username.")]
        [StringLength(255, ErrorMessage = "Username length cannot be greater than 255 characters. Please keep usernames below 255 characters. ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password field is required. Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email address field is required. Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        [Compare("ConfirmEmail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please confirm your email address.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Phone number field is required. Please enter a phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Compare("PhoneNumberConfirmed")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please confirm your phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Confirm Phone")]
        public string PhoneNumberConfirmed { get; set;}
    }
}

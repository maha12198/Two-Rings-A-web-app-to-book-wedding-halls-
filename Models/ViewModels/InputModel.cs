﻿using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models.ViewModels
{
    public class InputModel
    {
        [Required]

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]

        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 11)]
        [Display(Name = "Phone Number")]

        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Role")]
        public string role { get; set; }
    }
}

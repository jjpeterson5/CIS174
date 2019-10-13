using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Chapt2App.Models
{
    public class UserBindingModel
    {
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Range(2, 25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Confirm Email")]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Date), Display(Name = "Date of Birth")]
        [Range(1/1/1900, 12/31/2018)]
        public string DateOfBirth { get; set; } = "12345678";
               
        [Required]
        [DataType(DataType.Password), Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password), Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

                          
    }
   
 }
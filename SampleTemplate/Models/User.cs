using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SampleTemplate.Models;

namespace StudioBookingApp.Models
{
    public class User
    {
        //[Required]
        //public string UserID { get; set; }  //Primary Key in DB
        [Required]
        [RegularExpression("[A-Za-z]+")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("[A-Za-z]+")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [RegularExpression("[A-Za-z]+")]
        [Display(Name = "County")]
        public string County { get; set; }

        [Required]
        [StringLength(7, ErrorMessage = "Eircodes must be 7 alphanumeric characters", MinimumLength = 7)]
        [Display(Name = "Eircode")]
        public string Eircode { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "User Type")]
        public Role Type { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public User() { }

        //public User(string userID, string firstName, string lastName, string email, string password, string phone)

        //{
        //    UserID = userID;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    Password = password;
        //    Phone = phone;
        //}
    }


}
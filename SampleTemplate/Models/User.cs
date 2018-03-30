using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudioBookingApp.Models
{
    public class User
    {
        [Required]
        public string UserID { get; set; }  //Primary Key in DB
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public User(string userID, string firstName, string lastName, DateTime dob, string email, string password, string phone)

        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            Email = email;
            Password = password;
            Phone = phone;
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudioBookingApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public User(string name, string dob, string email, string password, string phone)

        {
            Name = name;
            DateOfBirth = dob;
            Email = email;
            Password = password;
            Phone = phone;
        }
    }


}
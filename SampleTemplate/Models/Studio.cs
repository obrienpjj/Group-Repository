using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudioBookingApp.Models
{
    public class Studio
    {
        public string StudioID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public decimal HourlyRate { get; set; }
        public string Address { get; set; }
        public string RoomImage { get; set; }

        public Studio() { }
        public Studio(string studioID, string name, string owner, decimal hourlyRate, string address, string roomImage) 
        {
            StudioID = studioID;
            Name = name;
            Owner = owner;
            HourlyRate = hourlyRate;
            Address = address;
            RoomImage = roomImage;
        }
    }
}
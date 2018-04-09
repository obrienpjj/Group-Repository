using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudioBookingApp.Models
{
    public class Studio
    {
        public string StudioID { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal HourlyRate { get; set; }
        

        public Studio() { }
        //public Studio(string studioID, string name, string studioImage, string type, string description, decimal hourlyRate) 
        //{
        //    StudioID = studioID;
        //    Name = name;
        //    Type = type;
        //    HourlyRate = hourlyRate;
        //    Image = studioImage;
        //    Description = description;
        //}
    }
}
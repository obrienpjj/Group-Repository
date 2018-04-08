using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SampleTemplate.Models;

namespace StudioBookingApp.Models
{
    public class DateCheck
    {
        public string ID { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public DateCheck() { }
    }
}
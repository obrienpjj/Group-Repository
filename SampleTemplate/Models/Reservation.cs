using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudioBookingApp.Models
{
    public class Reservation
    {
        [Required]
        public string ReservationID { get; set; }
        [Required]
        public string UserID{ get; set; }
        [Required]
        public string StudioID { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Cost { get; set; }

        public Reservation() { }

        public Reservation(string reservationID, string userID, string studioID, DateTime startTime, DateTime endTime, decimal cost)
        {
            ReservationID = ReservationID;
            UserID = userID;
            StudioID = studioID;
            StartTime = startTime;
            EndTime = endTime;
            Cost = cost;
        }
    }
}
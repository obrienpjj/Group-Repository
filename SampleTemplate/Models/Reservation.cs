using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudioBookingApp.Models
{
    public class Reservation
    {
        public string ReservationID { get; set; }
        public string UserID { get; set; }
        public string StudioID { get; set; }
        public DateTime BookingStartTime { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal Price { get; set; }

        public Reservation() { }

        public Reservation(string reservationID, string userID, string studioID, DateTime startTime, DateTime date, decimal totalCost)
        {
            ReservationID = ReservationID;
            UserID = userID;
            StudioID = studioID;
            BookingStartTime = startTime;
            BookingDate = date;
            Price = totalCost;
        }
    }
}
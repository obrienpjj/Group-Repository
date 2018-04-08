using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SampleTemplate.Models;

namespace StudioBookingApp.Models
{
    public class Reservation
    {
        
        public string ReservationID { get; set; }
        //[Required]
        public string UserID{ get; set; }
        //[Required]
        public string StudioID { get; set; }

        public DateTime Date { get; set; }

        public string BookTime { get;set; }

        public decimal Cost { get; set; }

        public DateTime DateCheck { get; set; }

        public IEnumerable<string> Available { get; set; }

        public Reservation() { }

        //public Reservation(string reservationID, string userID, string studioID, DateTime startTime, DateTime endTime, decimal cost)
        //{
        //    ReservationID = ReservationID;
        //    UserID = userID;
        //    StudioID = studioID;
        //    Cost = cost;
        //}
    }
}
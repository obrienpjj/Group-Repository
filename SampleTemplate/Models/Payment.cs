using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleTemplate.Models
{
    public class Payment
    {
        public string PaymentID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int CardNumber { get; set; }
        public int SSN { get; set; }
        public DateTime Expiry { get; set; }
        public string ReservationID { get; set; }

        public Payment() { }

        public Payment (string paymentID, DateTime date, decimal amount, int cardNumber, int ssn, DateTime expiry, string userID, string reservationID)
        {
            PaymentID = paymentID;
            Date = date;
            Amount = amount;
            CardNumber = cardNumber;
            SSN = ssn;
            Expiry = expiry;
            ReservationID = reservationID;
        }
    }
}
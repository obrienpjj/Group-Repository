using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using StudioBookingApp.Models;
using System.Web.Helpers;
using System.Xml;
using System.IO;
using System.Data;
using System.Web.Configuration;

namespace SampleTemplate.Models
{
    public class AddData : DAO
    {
        string message; 

        public AddData() { }

        public int InsertUser(User user)
        {
            int count = 0;
            //string password;

            SqlCommand cmd = new SqlCommand("INSERT INTO UserTable (FirstName, LastName, AddressLine1, AddressLine2, County, EIRCode, Email, Phone, Pass, UserType) VALUES (@FirstName, @LastName, @AddressLine1, @AddressLine2, @County, @EIRCode, @Email, @Phone, @Pass, @UserType)", openConnection());
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@AddressLine1", user.AddressLine1);
            cmd.Parameters.AddWithValue("@AddressLine2", user.AddressLine2);
            cmd.Parameters.AddWithValue("@County", user.County);
            cmd.Parameters.AddWithValue("@EIRCode", user.Eircode);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            //password = Crypto.HashPassword(user.Password);
            cmd.Parameters.AddWithValue("@Pass", user.Password);
            cmd.Parameters.AddWithValue("@UserType", user.Type);

            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                closeConnnection();
            }
            return count;
        }

        public int InsertStudio(Studio studio)
        {
            int count = 0;

            SqlCommand cmd = new SqlCommand("uspInsertStudio", openConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", studio.StudioID);
            cmd.Parameters.AddWithValue("@Name", studio.Name);
            cmd.Parameters.AddWithValue("@Image", studio.Image);
            cmd.Parameters.AddWithValue("@Type", studio.Type);
            cmd.Parameters.AddWithValue("@Description", studio.Description);
            cmd.Parameters.AddWithValue("@HourlyRate", studio.HourlyRate);

            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                closeConnnection();
            }
            return count;
        }

        public int InsertReservation(Reservation reservation)
        {
            int count = 0;

            SqlCommand cmd = new SqlCommand("uspInsertStudio", openConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReservationID", reservation.ReservationID);
            cmd.Parameters.AddWithValue("@UserID", reservation.UserID);
            cmd.Parameters.AddWithValue("@StudioID", reservation.StudioID);
            cmd.Parameters.AddWithValue("@StartTime", reservation.StartTime);
            cmd.Parameters.AddWithValue("@EndTime", reservation.EndTime);
            cmd.Parameters.AddWithValue("@Cost", reservation.Cost);

            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                closeConnnection();
            }
            return count;
        }

        public int InsertPayment(Payment payment)
        {
            int count = 0;

            SqlCommand cmd = new SqlCommand("uspInsertPayment", openConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PaymentID", payment.PaymentID);
            cmd.Parameters.AddWithValue("@Amount", payment.Amount);
            cmd.Parameters.AddWithValue("@Date", payment.Date);
            cmd.Parameters.AddWithValue("@CardNumber", payment.CardNumber);
            cmd.Parameters.AddWithValue("@Expiry", payment.Expiry);
            cmd.Parameters.AddWithValue("@SSN", payment.SSN);
            cmd.Parameters.AddWithValue("@ReservationID", payment.ReservationID);

            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                closeConnnection();
            }
            return count;
        }
    }
}
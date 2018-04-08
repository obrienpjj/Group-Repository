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
    public class DAO
    {
        private SqlConnection conn;
        public string message;

        public DAO()
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\obrie\\Documents\\College Stuff\\B8IT121\\Visual Studio Files\\Group Repository\\SampleTemplate\\App_Data\\StudioBookingApp.mdf\"; Integrated Security = True;");
        }
        public SqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed ||
                conn.State == System.Data.ConnectionState.Broken)
                conn.Open();
            return conn;
        }
        public void closeConnnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public string CheckLogin(User user)
        {
            string password, firstName = null;
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable WHERE @email=Email", openConnection()); //Need to make this procedure, return student list for a given email address
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", user.Email);

            

            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    password = reader["Pass"].ToString();
                    if (password==user.Password)
                    {
                        firstName = reader["FirstName"].ToString(); //The text in quotes needs to match what is in the Sql Stored Procedure

                    }
                    else
                    {
                        message = "Please check your password and try again";
                    }
                }
            }
            catch (SqlException ex)
            {
                message = ex.Message;
            }
            catch (FormatException ex1)
            {
                message = ex1.Message;
            }
            finally
            {
                closeConnnection();
            }

            return firstName;
        }
    }
}
using SampleTemplate.Models;
using StudioBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudioBookingApp.Controllers
{
    public class BookingController : Controller
    {
        GetData getData = new GetData();
        AddData addData = new AddData();

        // GET: Booking
        public ActionResult Index(string session)
        {
            Session["studio"] = session.ToString();
            //DateTime date = new DateTime();
            //GetData get = new GetData();

            //DateTime defaultDate = DateTime.Now;

            //IEnumerable<Slot> slots = get.GetSlots(defaultDate); //need to pass date from view
            //List <Slot> slots = new List<Slot>
            //            {
            //                Slot.Morning,
            //                Slot.Afternoon,
            //                Slot.Daylong
            //            };
            //Reservation reservation = new Reservation();
            //reservation.Available = slots.AsEnumerable<Slot>();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Reservation reservation)
        {
            //Session["studio"] = "01";
            GetData get = new GetData();
            string StudioID = Session["studio"].ToString();
            reservation.StudioID = Session["studio"].ToString();

            IEnumerable<string> slots = get.GetSlots(reservation.DateCheck, StudioID);
            reservation.Available = slots;



            //List<string> slotss = new List<string>
            //            {
            //                //Slot.Morning,
            //                //Slot.Afternoon,
            //                "Daylong"
            //            };

            //reservation.Available = slotss.AsEnumerable<string>();
            Session["status"] = "clicked";

            return View("Index", reservation);

        }


        [HttpPost]
        public ActionResult BookBook(Reservation reservation)
        {
            //Session["name"] = "Jim";
            reservation.UserID =getData.GetUserID(Session["name"].ToString());
            //reservation.StudioID = "01"; /* Session["studio"].ToString();*/
            reservation.StudioID = Session["studio"].ToString();

            int count = 0;
            if (ModelState.IsValid)
            {
                count = addData.InsertReservation(reservation);
                if (count == 1)
                {
                    ViewBag.Status = "User account created successfully!";
                }
                else
                {
                    ViewBag.Status = "Error! " + addData.message;
                }
            }
            return RedirectToAction("Index", "Paypal", new { item_name_1 = "Studio", item_number_1 = "01", amount_1 = "1", quantity_1 = "1" });
        }
    }
}
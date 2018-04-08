using StudioBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudioBookingApp.Controllers
{
    public class StudiosController : Controller
    {
        // GET: Studios
        public ActionResult Index()
        {

            List<Studio> studioList = new List<Studio>()
            {
         // public Studio(string studioID, string name, string studioImage, string type, string description, decimal hourlyRate) 
                new Studio("STU001", "The Red Room", "theredroom.jpg", "Small", "A Small to Medium Sized Rehearsal Space. Comes With" +
                "Drum Kit, Guitar Amp, Bass Amp, and a Gibson Epiphone Electric. No PA or microphones " +
                "provided.", 35),
                new Studio("STU002", "The Blue Room", "theblueroom.png", "Medium", "A Medium to Large Sized Rehearsal Space. Comes With" +
                "Drum Kit, Guitar Amp, Bass Amp, and a Small PA System. Three MicroPhones Provided.", 50),
                new Studio("STU003", "The Yellow Room", "theyellowroom.jpg", "Large", "This is our Largest Rehearsal Space. Fully Furnished with Drums, Amps," +
                  "and a full PA System.", 70)
            };

            return View(studioList);
        }
    }
}
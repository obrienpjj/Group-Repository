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
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleTemplate.Models;

namespace SampleTemplate.Controllers
{
    public class PayPalController : Controller
    {
        // GET: PayPal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            ViewBag.result = PDTHolder.Success(Request.QueryString.Get("tx"));
            return View("Success");
        }
    }
}
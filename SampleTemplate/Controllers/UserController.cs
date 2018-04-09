using SampleTemplate.Models;
using StudioBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleTemplate.Controllers
{
    public class UserController : Controller
    {
        AddData addData = new AddData();
        GetData getData = new GetData();
        DAO dao = new DAO();

        // GET: User
        public ActionResult Index()
        {
            return View("Register");
        }

        //public ActionResult Register()
        //{
        //    return View("Register");
        //}
        
        [HttpPost]
        public ActionResult Register(User user)
        {
            int count = 0;
            if (ModelState.IsValid)
            {
                count = addData.InsertUser(user);
                if (count == 1)
                {
                    ViewBag.Status = "User account created successfully!";
                }
                else
                {
                    ViewBag.Status = "Error! " + addData.message;
                }
            }
            return View("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            ModelState.Remove("AddressLine1");
            ModelState.Remove("AddressLine2");
            ModelState.Remove("Phone");
            ModelState.Remove("County");
            ModelState.Remove("Eircode");
            ModelState.Remove("ConfirmPassword");

            if (ModelState.IsValid)
            {
                if (user.Type == Role.Staff)
                {
                    user.FirstName = dao.CheckLogin(user);
                    if (user.FirstName != null /*|| user.Password=="Password"*/)
                    {
                        Session["name"] = user.FirstName;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Status = "Error";
                        return View("Status");
                    }
                }

                else if (user.Type == Role.User)
                {
                    user.FirstName = dao.CheckLogin(user);
                    if (user.FirstName != null)
                    {
                        Session["name"] = user.FirstName;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Status = "Error";
                        return View("Status");
                    }
                }
            }
            

            return View(user);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
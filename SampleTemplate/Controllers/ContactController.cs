using SampleTemplate.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudioBookingApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        static DataSet ds;
        static DataTable dt;

        // GET: Contact
        public ActionResult Index()
        {
            if (System.IO.File.Exists(Server.MapPath("~/App_Data/suggestions.xml")))
            {
                ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/App_Data/suggestions.xml"));
                dt = ds.Tables[0];
            }
            else
            {

                ds = new DataSet("user_contact");
                dt = new DataTable("suggestions");
                dt.Columns.Add("Name");
                dt.Columns.Add("Email");
                dt.Columns.Add("Suggestions");
                ds.Tables.Add(dt);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                DataRow row = dt.NewRow();
                if (model.Name == "" || model.Name == null)
                {
                    row["name"] = "name not entered";
                }
                else row["Name"] = model.Name;
                row["Email"] = model.Email;
                row["Suggestions"] = model.Comments;
                dt.Rows.Add(row);
                dt.AcceptChanges();
                ds.WriteXml(Server.MapPath("~/App_Data/suggestions.xml"));
                ViewData["message"] = "Record entered successfully";
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        public ActionResult ShowFeedback()
        {
            List<ContactModel> list = new List<ContactModel>();
            if (System.IO.File.Exists(Server.MapPath("~/App_Data/suggestions.xml")))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Server.MapPath("~/App_Data/suggestions.xml"));
                DataTable table = dataSet.Tables[0];
                foreach (DataRow row in table.Rows)
                {
                    ContactModel model = new ContactModel();
                    model.Name = row[0].ToString();
                    model.Email = row[1].ToString();
                    model.Comments = row[2].ToString();
                    list.Add(model);
                }
                ViewData["message"] = "";
            }
            else
            {
                ViewData["message"] = "User suggestion was not recorded";
            }

            return View(list);
        }
    }
}
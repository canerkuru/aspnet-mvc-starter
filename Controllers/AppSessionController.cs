using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspnet_mvc_starter.Models;
using System.Data;

namespace aspnet_mvc_starter.Controllers
{
    public class AppSessionController : Controller
    {
        public ActionResult Index()
        {
            User user = new Models.User();
            if (Session["user"] != null)
            {
                user = (User)Session["user"];
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "ID,UserName,UserPassword,FirstName,LastName,UserEMail,UserTitle")] User user)
        {
            Session["user"] = user;

            return RedirectToAction("Index");
        }


    }


}
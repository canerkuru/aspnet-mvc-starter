using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace aspnet_mvc_starter.Controllers
{
    public class AppBasicController : Controller
    {
        public AppBasicController()
        {
            List<string> Student = new List<string>();
            Student.Add("Caner");
            Student.Add("Ayhan");
            Student.Add("Ugur");

            ViewBag.Student = Student;
        }
        
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC";
            TempData["value"] = "someValueForNextRequest";

            return View();
        }
        
        public ActionResult IndexjQuery()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            };
            return Json(person);
        }

        public ActionResult Weather()
        {
            return View();
        }


    }

    public class PersonModel
    {
        public string Name { get; set; }
        public string DateTime { get; set; }
    }

}
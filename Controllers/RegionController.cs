using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using aspnet_mvc_starter.Models.EntityModel;
using System.Data.Entity;

namespace aspnet_mvc_starter.Controllers
{
    

    public class RegionController : Controller
    {
        private NORTHWNDEntities db = new NORTHWNDEntities();
        


        public ActionResult Index()
        {
            return View();
        }


        public JsonResult List()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return Json(db.Region.AsNoTracking(), JsonRequestBehavior.AllowGet);
        }




        public JsonResult Add(Region emp)
        {
            db.Region.Add(emp);
            db.SaveChanges();

            return Json("1", JsonRequestBehavior.AllowGet);
            
        }
        public JsonResult GetbyID(int ID)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var Employee = db.Region.Find(ID);
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Region emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();

            return Json("1", JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int ID)
        {
            Region region = db.Region.Find(ID);
            db.Region.Remove(region);
            db.SaveChanges();

            return Json("1", JsonRequestBehavior.AllowGet);
        }


    }
}
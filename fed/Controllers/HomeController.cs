using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fed.Models;

namespace fed.Controllers
{
    public class HomeController : Controller
    {
        FedContext db = new FedContext();

        public ActionResult Index()
        {

            //Siteuser su = new Siteuser();

            //su.name = "Egor";
            //su.age = 20;
            //su.id = 100;

            //db.Siteusers.Add(su);
            //db.SaveChanges();

            using (FedContext db = new FedContext())
            {
                db.Siteusers.Add(new Siteuser { name = "Seriozha", age = 34 });
                db.SaveChanges();

                ViewBag.list = db.Siteusers.ToList();


                IEnumerable<Siteuser> siteuser1 = db.Siteusers;
                ViewBag.Siteuser = siteuser1;

                //ViewBag.Siteuser_ = (from siteuser in db.Siteusers
                //                    where siteuser.id == 3
                //                    select siteuser).First();
                ViewBag.Fed = "Fed Ihor";
                ViewData["Head"] = "Привет мир!";




                

            }

            
            

            return View("Index");
        }

    }
}

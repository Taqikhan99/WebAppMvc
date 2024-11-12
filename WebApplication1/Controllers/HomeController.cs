using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbClass dbClass;
        public HomeController()
        {
            dbClass = new DbClass();
        }
       

        public ActionResult Index()
        {
            DataTable dt= dbClass.execQuery("Select * from AspNetUsers");

            ViewBag.Message = "Congratulations for new home";
            ViewBag.DataTable = dt;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application New Desc page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page hero.";

            return View();
        }
    }
}
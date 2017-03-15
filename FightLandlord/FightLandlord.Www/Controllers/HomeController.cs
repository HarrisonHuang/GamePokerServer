using FightLandlord.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FightLandlord.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            List<Poker> pokers = new List<Poker>();
            pokers.Add(new Poker(3, 3));
            pokers.Add(new Poker(5, 1));
            pokers.Add(new Poker(3, 2));
            pokers.Add(new Poker(10, 2));
            pokers.Add(new Poker(6, 4));
            pokers.Add(new Poker(8, 2));
            pokers.Sort();
            return Json(pokers, JsonRequestBehavior.AllowGet);
        }
    }
}
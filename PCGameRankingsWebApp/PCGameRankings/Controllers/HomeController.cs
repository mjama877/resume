using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCGameRankings.Context;

namespace PCGameRankings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = " About Game Rankings";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page.";

            return View();
        }
        public ActionResult GameRankings()
        {
            ViewBag.Message = "Game Rankings";
            var context = new GameContext();
            return View(context.PCGame.ToList());
            
        }
    }
}
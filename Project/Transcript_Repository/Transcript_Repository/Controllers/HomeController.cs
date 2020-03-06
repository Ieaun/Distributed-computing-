using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transcript_Repository.Controllers
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

        public ActionResult Transcripts()
        {
            ViewBag.Message = "Your transcripts page.";

            return View();
        }

        public ActionResult Actions()
        {
            ViewBag.Message = "Your actions page.";

            return View();
        }

        public ActionResult Detailed_Transcript()
        {
            ViewBag.Message = "Your detailed transcript page.";

            return View();
        }

    }
}
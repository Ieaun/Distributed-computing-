using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transcript_Repository.Controllers
{
    public class SeeTranscriptsController : Controller
    {
        // GET: SeeTranscripts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detailed_Transcript()
        {
            ViewBag.Message = "Your detailed transcript page.";

            return View();
        }
    }
}
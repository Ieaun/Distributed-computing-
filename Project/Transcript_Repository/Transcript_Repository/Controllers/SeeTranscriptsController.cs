using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transcript_Repository.DtoModels.Module;
using Transcript_Repository.DtoModels.Transcript;
using Transcript_Repository.ViewModels;

namespace Transcript_Repository.Controllers
{
    public class SeeTranscriptsController : Controller
    {
        // GET: SeeTranscripts
        public ActionResult Index()
        {
            //////////////////mock Modules 
            List<ModuleDto> Mock_Modules = new List<ModuleDto>();
            string ModuleName = "Module_";
            for (int i = 0; i < 6; i++)
            {
                ModuleDto newModule = new ModuleDto
                {
                    ACWGrade = 5* i,
                    ModuleGrade = 60 - (i),
                    Module_ACWs = ModuleName + i,
                    Module_ID = 700098
                };
                Mock_Modules.Add(newModule);
            }

            //mock transcript
            TranscriptDto Transcript_mock = new TranscriptDto
            {
                EnrolledCourseID= 20,
                SemesterID= 1,
                Transcript_ID = 523321,
                Modules_Taken = Mock_Modules

            };
           

            var model = new TranscriptViewModel();
            model.Transcripts.Add(Transcript_mock);
     

            return View(model);
        }

        public ActionResult Detailed_Transcript()
        {
            ViewBag.Message = "Your detailed transcript page.";

            return View();
        }
    }
}
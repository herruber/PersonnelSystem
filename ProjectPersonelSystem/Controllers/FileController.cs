using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProjectPersonelSystem.Controllers
{
    public class FileController : Controller
    {

        Repositories.FileHandler fhandler = new Repositories.FileHandler();

        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public JsonResult GetFiles(string company, string department)
        {
            var bajs = fhandler.GetAllFiles(company, department, Server);

            return Json(bajs, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewFile(string filename)
        {
            var fileName = Path.GetFileName(filename);
            Response.AppendHeader("content-disposition", "inline; filename=" + fileName);
            return fhandler.ViewFile(filename);
        }

        [HttpPost]
        public ActionResult Upload(string company = "TestCompany1", string department = "TestDepartment1")
        {
            if (Request.Files.Count > 0)
            {
                var files = Request.Files;

                if (files != null)
                {

                    for (int i = 0; i < files.Count; i++)
                    {
                        var path = Path.Combine(Server.MapPath("/Files/TestCompany1/TestDepartment1/"), Path.GetFileName(files[i].FileName));
                        files[i].SaveAs(path);
                    }
                    
                }
            }

            return View("UploadStatus");
        }


    }
}
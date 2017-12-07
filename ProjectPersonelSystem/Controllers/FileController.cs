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


        // GET: File
        public ActionResult Index()
        {
            return View();
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
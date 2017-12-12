using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectPersonelSystem.Repositories;


namespace ProjectPersonelSystem.Controllers
{
    public class FileController : Controller
    {

        FileHandler fHandler = new FileHandler();

        // GET: File
        public ActionResult Index()
        {
            return View(fHandler.GetAllFiles("TestCompany1", "TestDepartment1", Server));
        }

        [HttpGet]
        public JsonResult GetFiles(string company, string department)
        {
            List<string> files = fHandler.GetAllFiles(company, department, Server);
            return Json(files, JsonRequestBehavior.AllowGet);
        }

        public FileResult ViewFile(string company, string department, string file)
        {

            byte[] fileBytes = fHandler.GetFileBytes(company, department, file, Server);
            string fileName = file;

            return File(Server.MapPath("~/Files/" + company + "/" + department + "/" + file), file);

        }

        public ActionResult Delete(string company, string department, string file)
        {
            fHandler.DeleteFile(company, department, file, Server);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Upload(string company = "TestCompany1", string department = "TestDepartment1")
        {
            if (Request.Files.Count > 0 && Request.Files[0].ContentLength > 0)
            {
                var files = Request.Files;

                    for (int i = 0; i < files.Count; i++)
                    {
                        var path = Path.Combine(Server.MapPath("/Files/TestCompany1/TestDepartment1/"), Path.GetFileName(files[i].FileName));
                        files[i].SaveAs(path);
                    }

                    return View("UploadStatus");
            }
            else
            {
                return RedirectToAction("Index");
            }          
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace ProjectPersonelSystem.Repositories
{
    public class FileHandler
    {


        public string GetPath(string company, string department, string fileName, HttpServerUtilityBase Server)
        {
            string path ="~/Files/" +company +"/" +department + "/";

            Directory.CreateDirectory(Server.MapPath(path));

            return Server.MapPath(path + fileName);
        }

        public List<string> GetAllFiles(string company, string department, HttpServerUtilityBase Server)
        {
            string path = "~/Files/" + company + "/" + department + "/";
            //DirectoryInfo dir = new DirectoryInfo();
            List<string> files = Directory.GetFiles(Server.MapPath(path)).ToList();
            return files;
        }

        public FileStreamResult ViewFile(string filename)
        {
            var fileStream = new FileStream(filename,
                                     FileMode.Open,
                                     FileAccess.Read
                                   );

            var fsResult = new FileStreamResult(fileStream, "application/img");
            return fsResult;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ProjectPersonelSystem.Repositories
{
    public class FileHandler
    {


        public string GetPath(string department, string company, string fileName)
        {
            string path ="~/Files/" +company +"/" +department + "/";

            Directory.CreateDirectory(path);

            return path + fileName;
        }

        public List<string> GetAllFiles(string department, string company)
        {
            string path = "~/Files/" + company + "/" + department + "/";
            return Directory.GetFiles(path).ToList();
        }
    }
}
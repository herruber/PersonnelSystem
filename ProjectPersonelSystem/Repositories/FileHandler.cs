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

        public List<string> GetAllFiles(string company, string department, HttpServerUtilityBase server)
        {
            string path = server.MapPath("~/Files/" + company + "/" + department + "/");
            return Directory.GetFiles(path).Select(e => Path.GetFileName(e)).ToList();
        }

        public void DeleteFile(string company, string department, string file, HttpServerUtilityBase server)
        {
            string path = server.MapPath("~/Files/" + company + "/" + department + "/");
            var files = Directory.GetFiles(path);
            File.Delete(files.FirstOrDefault(e => Path.GetFileName(e) == file));

        }

        public byte[] GetFileBytes(string company, string department, string file, HttpServerUtilityBase server)
        {
            string path = server.MapPath("~/Files/" + company + "/" + department + "/");
            byte[] filebytes = File.ReadAllBytes(server.MapPath("~/Files/" + company + "/" + department + "/" +file));
            return filebytes;

            //return new FileStream(Directory.GetFiles(path).FirstOrDefault(e => Path.GetFileName(e) == file), FileMode.Open);
        }
    }
}
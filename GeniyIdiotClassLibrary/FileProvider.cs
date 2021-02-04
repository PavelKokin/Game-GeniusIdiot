using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotClassLibrary
{
    class FileProvider
    {
        public static void Append(string path, string data)
        {
            var writer = new StreamWriter(path, true, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static void Replase(string path, string data)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static string Get(string path)
        {
            var reader = new StreamReader(path, Encoding.UTF8);
            var fileData = reader.ReadToEnd();
            reader.Close();
            return fileData;
        }

        public static bool Exist(string path)
        {
            var fileinfo = new FileInfo(path);
            return fileinfo.Exists;
        }
    }
}

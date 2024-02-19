using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardTemplate.utilities
{
    internal class FileManager
    {
        public static string[] GetFilesInPath()
        {
            return Directory.EnumerateFiles("filespathhere").ToArray();
        }

        public static string GetFileContent(string path)
        {
            return File.ReadAllText(path);
        }
    }
}

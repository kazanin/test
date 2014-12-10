using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzemkoGraphics.Utils
{
    public static class FilenameGenerator
    {
        public static void Generate(ref string fullPath)
        {

            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            string extension = Path.GetExtension(fullPath);
            string path = Path.GetDirectoryName(fullPath);

            while (File.Exists(fullPath))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                string newFullPath = Path.Combine(path, tempFileName + extension);
                fullPath = newFullPath;
            }

           
        }
    }
}

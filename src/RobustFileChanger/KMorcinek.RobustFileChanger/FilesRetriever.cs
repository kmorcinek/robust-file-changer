using System.Collections.Generic;
using System.IO;

namespace KMorcinek.RobustFileChanger
{
    class FilesRetriever
    {
        public static IEnumerable<string> GetFiles(string basePath)
        {
            return Directory.EnumerateFiles(basePath, "*.ts", SearchOption.AllDirectories);
        }
    }
}
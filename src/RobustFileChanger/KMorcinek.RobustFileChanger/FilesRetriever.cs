using System.Collections.Generic;
using System.IO;

namespace KMorcinek.RobustFileChanger
{
    class FilesRetriever
    {
        public static IEnumerable<string> GetFiles(string basePath, string searchPattern)
        {
            return Directory.EnumerateFiles(basePath, searchPattern, SearchOption.AllDirectories);
        }
    }
}
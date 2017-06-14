using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger
{
    public class Runner
    {
        public static void Run(string basePath, IFileChanger fileChanger)
        {
            // Then in "clean" mode you only copy files to folder ../TryChanges (recreated)

            IEnumerable<string> files = FilesRetriever.GetFiles(basePath, fileChanger.SearchPattern).ToList();

            foreach (var pathToFile in files)
            {
                Console.WriteLine(pathToFile);

                var content = File.ReadAllText(pathToFile);

                if (fileChanger.IsMatch(content))
                {
                    var result = fileChanger.Transform(content);

                    File.WriteAllText(pathToFile, result); 
                }
            }
        }
    }
}
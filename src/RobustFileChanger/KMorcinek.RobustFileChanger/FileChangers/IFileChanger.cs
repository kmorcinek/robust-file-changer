using System.Collections.Generic;

namespace KMorcinek.RobustFileChanger.FileChangers
{
    public interface IFileChanger
    {
        bool IsMatch(string content);
        string Transform(string content);
        bool IsMatch(string[] lines);
        IEnumerable<string> Transform(string[] lines);
    }
}
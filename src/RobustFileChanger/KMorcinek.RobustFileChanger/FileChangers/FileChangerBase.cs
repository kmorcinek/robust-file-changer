using System;
using System.Collections.Generic;

namespace KMorcinek.RobustFileChanger.FileChangers
{
    public abstract class FileChangerBase : IFileChanger
    {
        public virtual bool IsMatch(string content)
        {
            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            return IsMatch(lines);
        }

        public virtual string Transform(string content)
        {
            string[] lines = content.Split(new []{Environment.NewLine}, StringSplitOptions.None);

            IEnumerable<string> transformedLines = Transform(lines);

            return string.Join(Environment.NewLine, transformedLines);
        }

        public abstract bool IsMatch(string[] lines);
        public abstract IEnumerable<string> Transform(string[] lines);
    }
}
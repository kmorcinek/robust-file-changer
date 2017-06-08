using System.Collections.Generic;
using System.Linq;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers
{
    public class RemoveReferenceComment : FileChangerBase
    {
        public override bool IsMatch(string[] lines)
        {
            var firstLine = lines.First();

            return firstLine != null &&
                   firstLine.Contains("/// <reference path=");
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            var firstLine = lines.First();

            if (firstLine != null &&
                firstLine.Contains("/// <reference path="))
            {
                return lines.Skip(2);
            }

            return lines;
        }
    }
}
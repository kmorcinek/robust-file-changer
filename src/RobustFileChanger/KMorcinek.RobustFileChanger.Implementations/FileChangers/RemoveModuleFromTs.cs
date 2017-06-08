using System.Collections.Generic;
using System.Linq;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers
{
    public class RemoveModuleFromTs : FileChangerBase
    {
        public override bool IsMatch(string[] lines)
        {
            var firstLine = lines.First();

            return firstLine != null &&
                   firstLine.Contains("module BomManager {");
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            lines = lines.Skip(1).ToArray();

            if (lines[0].Contains("strict"))
            {
                lines = lines.Skip(1).ToArray();
            }

            return lines.Take(lines.Length - 1);
        }
    }
}
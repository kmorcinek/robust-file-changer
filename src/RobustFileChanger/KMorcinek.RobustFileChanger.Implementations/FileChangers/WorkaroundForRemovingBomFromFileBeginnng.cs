using System.Collections.Generic;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers
{
    public class WorkaroundForRemovingBomFromFileBeginnng : FileChangerBase
    {
        public override bool IsMatch(string[] lines)
        {
            return true;
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            return lines;
        }

        public override string SearchPattern => "*.ts";
    }
}
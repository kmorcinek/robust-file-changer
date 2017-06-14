using System.Collections.Generic;
using System.Linq;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.RewritePath
{
    public class RewritePathToNugetsForSelenium : FileChangerBase
    {
        public override bool IsMatch(string[] lines)
        {
            return true;
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            var enumerable = lines.Select(x => x.Replace(@"..\..\..\..\..\NuGets\", @"..\..\packages\"));
            return enumerable;
        }

        public override string SearchPattern => "*UiTests.csproj";
    }
}
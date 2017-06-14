using System.Collections.Generic;
using System.Linq;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.RewritePath
{
    public class RewritePathToNugetsForTests : FileChangerBase
    {
        readonly int _depth;

        public RewritePathToNugetsForTests(int depth)
        {
            _depth = depth;
        }

        public override bool IsMatch(string[] lines)
        {
            return true;
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            string depth = string.Join("", Enumerable.Repeat(@"..\", _depth));

            var enumerable = lines.Select(x => x.Replace($@"<HintPath>{depth}..\..\..\..\NuGets\", $@"<HintPath>{depth}..\packages\"));
            return enumerable;
        }

        public override string SearchPattern => "*.csproj";
    }
}
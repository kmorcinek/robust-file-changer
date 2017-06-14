using System.Collections.Generic;
using System.Linq;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.RewritePath
{
    public class RewritePathToNugets : FileChangerBase
    {
        readonly int _depth;

        public RewritePathToNugets(int depth)
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
            var enumerable = lines.Select(x => x.Replace(@"<Analyzer Include=""..\..\..\..\NuGets\", $@"<Analyzer Include=""{depth}..\packages\"));

            enumerable = enumerable.Select(x => x.Replace(@"<HintPath>..\..\..\..\NuGets\", $@"<HintPath>{depth}..\packages\"));
            return enumerable;
        }

        public override string SearchPattern => "*.csproj";
    }
}
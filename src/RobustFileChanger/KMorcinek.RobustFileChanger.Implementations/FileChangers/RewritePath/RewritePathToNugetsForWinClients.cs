using System.Collections.Generic;
using System.Linq;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.RewritePath
{
    public class RewritePathToNugetsForWinClients : RewritePathToNugetsForTests
    {
        public RewritePathToNugetsForWinClients(int depth)
            : base(depth)
        {
        }

        public override bool IsMatch(string[] lines)
        {
            return true;
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            var enumerable = lines.Select(x => x.Replace($@"..\..\..\NuGets\", $@"..\..\packages\"));
            return enumerable;
        }

        public override string SearchPattern => "*WindowsClient*.csproj";
    }
}
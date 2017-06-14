using System.Collections.Generic;
using System.Linq;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers
{
    public class AddUnderscoreImport : FileChangerBase
    {
        public override bool IsMatch(string[] lines)
        {
            return lines.Any(x => x.Contains("_."));
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            return new[] { @"import * as _ from ""underscore""" }.Concat(lines);
        }

        public override string SearchPattern => "*.ts";
    }
}
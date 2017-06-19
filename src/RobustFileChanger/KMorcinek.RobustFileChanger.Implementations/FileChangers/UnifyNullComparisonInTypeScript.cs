using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using KMorcinek.RobustFileChanger.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers
{
    public class UnifyNullComparisonInTypeScript : FileChangerBase
    {
        public override bool IsMatch(string[] lines)
        {
            return true;
        }

        public override IEnumerable<string> Transform(string[] lines)
        {
            // Regexes are never easy, but you can always look at Unit Tests
            // Regex was developed using http://regexstorm.net/tester
            var regex = new Regex(@"(\w+)\s*((!=)|(==))=*\s*((undefined)|(null))");

            return lines.Select(x => regex.Replace(x, "$1 $2 null"));
        }

        public override string SearchPattern => "*.ts";
    }
}
using KMorcinek.RobustFileChanger.Implementations.FileChangers;

namespace KMorcinek.RobustFileChanger.Implementations
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner.Run(
                @"path/to/your/repo",
                new UnifyNullComparisonInTypeScript());
        }
    }
}

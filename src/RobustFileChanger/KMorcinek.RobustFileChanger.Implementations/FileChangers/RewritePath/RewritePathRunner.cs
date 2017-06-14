namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.RewritePath
{
    public class RewritePathRunner
    {
        public static void RewritePath()
        {
            Runner.Run(
                @"C:\SRC\Prime\src\WindowsClient\tests",
                new RewritePathToNugets(2));

            Runner.Run(
                @"C:\SRC\Prime\src\WindowsClient",
                new RewritePathToNugets(1));

            Runner.Run(
                @"C:\SRC\Prime\src",
                new RewritePathToNugets(0));

            Runner.Run(
                @"C:\SRC\Prime\src\tests",
                new RewritePathToNugetsForTests(1));

            Runner.Run(
                @"C:\SRC\Prime\src\tests",
                new RewritePathToNugetsForTests(2));

            Runner.Run(
                @"C:\SRC\Prime\src\WindowsClient",
                new RewritePathToNugetsForWinClients(2));

            Runner.Run(
                @"C:\SRC\Prime\src",
                new RewritePathToNugetsForWebApp());

            Runner.Run(
                @"C:\SRC\Prime\src",
                new RewritePathToNugetsForSelenium());
        }
    }
}
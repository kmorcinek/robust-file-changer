using FluentAssertions;
using Xunit;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.Tests
{
    public class UnifyNullComparisonInTypeScriptTests
    {
        [Theory]
        [InlineData("cos !== undefined", "cos != null")]
        [InlineData("cos != undefined", "cos != null")]
        [InlineData("cos!=undefined", "cos != null")]
        [InlineData("cos != null", "cos != null")]
        [InlineData("cos === null", "cos == null")]
        public void IsMatch(string input, string expected)
        {
            string result = new UnifyNullComparisonInTypeScript().Transform(input);

            result.Should().Be(expected);
        }
    }
}
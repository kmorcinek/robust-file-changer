using FluentAssertions;
using Xunit;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.Tests
{
    public class RemoveReferenceCommentTests
    {
        [Fact]
        public void Transform()
        {
            string content = @"/// <reference path='../../_references.ts' />

module BomManager {
    'use strict';";

            string expected = @"module BomManager {
    'use strict';";

            string result = CreateSut().Transform(content);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(@"/// <reference path='../../_references.ts' />

module BomManager {
    'use strict';", true)]
        [InlineData(@"module BomManager {
    'use strict';", false)]
        public void IsMatch(string content, bool expected)
        {
            bool result = CreateSut().IsMatch(content);

            result.Should().Be(expected);
        }

        static RemoveReferenceComment CreateSut()
        {
            return new RemoveReferenceComment();
        }
    }
}
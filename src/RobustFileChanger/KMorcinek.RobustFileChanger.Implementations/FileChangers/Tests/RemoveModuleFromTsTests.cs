using FluentAssertions;
using Xunit;

namespace KMorcinek.RobustFileChanger.Implementations.FileChangers.Tests
{
    public class RemoveModuleFromTsTests
    {
        [Theory]
        [InlineData(@"module BomManager {
    'use strict';

    export class UpdateCurrentUserService {
    }
}", true)]
        public void IsMatch(string content, bool expected)
        {
            var isMatch = CreateSut().IsMatch(content);

            isMatch.Should().Be(expected);
        }

        [Fact]
        public void Transform()
        {
            string content = @"module BomManager {
    'use strict';

    export class UpdateCurrentUserService {
    }
}";

            string expected = @"
    export class UpdateCurrentUserService {
    }";

            CreateSut().Transform(content).Should().Be(expected);
        }

        [Fact]
        public void Transform_for_Unit_test_files()
        {
            string content = @"module BomManager {
    export class UpdateCurrentUserService {
    }
}";

            string expected = @"    export class UpdateCurrentUserService {
    }";

            CreateSut().Transform(content).Should().Be(expected);
        }

        static RemoveModuleFromTs CreateSut()
        {
            return new RemoveModuleFromTs();
        }
    }
}
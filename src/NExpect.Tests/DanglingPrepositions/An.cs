﻿using NExpect.Exceptions;
using NExpect.Interfaces;
using NExpect.MatcherLogic;
using NUnit.Framework;

namespace NExpect.Tests.DanglingPrepositions
{
    [TestFixture]
    public class An
    {
        [Test]
        public void ShouldProvideExtensionPoint()
        {
            // Arrange

            // Pre-Assert

            // Act
            Assert.That(() =>
            {
                Expectations.Expect(new Ostrich() as object).To.Be.An.Ostrich();
            }, Throws.Nothing);

            Assert.That(() =>
            {
                Expectations.Expect(new Ostrich() as object).Not.To.Be.An.Ostrich();
            }, Throws.Exception.InstanceOf<UnmetExpectationException>()
                .With.Message.Contains("Expected not to get an Ostrich"));

            // Assert
        }
    }

    public class Ostrich
    {
    }

    public static class ExtensionsForTestingAn
    {
        public static void Ostrich(this IAn<object> continuation)
        {
            continuation.AddMatcher(o =>
            {
                var passed = o is Ostrich;
                var message = passed ? "Expected not to get an Ostrich": "Expected to get an Ostrich";
                return new MatcherResult(passed, message);
            });
        }
    }
}
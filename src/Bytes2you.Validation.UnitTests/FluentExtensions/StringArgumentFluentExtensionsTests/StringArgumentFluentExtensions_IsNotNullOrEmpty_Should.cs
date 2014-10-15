﻿using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.StringArgumentFluentExtensionsTests
{
    [TestClass]
    public class StringArgumentFluentExtensions_IsNotNullOrEmpty_Should
    {
        [TestMethod]
        public void AddNotNullOrEmptyStringValidationRule()
        {
            // Arrange.
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", "string");

            // Act.
            argument.IsNotNullOrEmpty();

            // Assert.
            Assert.AreEqual(1, argument.ValidationRules.Count());
            Assert.IsTrue(argument.ValidationRules.First() is NotNullOrEmptyStringValidationRule);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", "string");

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNotNullOrEmpty();
                },
                PerformanceConstants.RuleExecutionCount,
                PerformanceConstants.RuleTotalExecutionExpectedTime);
        }
    }
}
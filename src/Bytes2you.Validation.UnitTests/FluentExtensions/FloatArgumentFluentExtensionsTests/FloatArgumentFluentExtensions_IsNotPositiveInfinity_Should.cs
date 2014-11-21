﻿using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.FloatArgumentFluentExtensionsTests
{
    [TestClass]
    public class FloatArgumentFluentExtensions_IsNotPositiveInfinity_Should
    {
        [TestMethod]
        public void AddFloatNotPositiveInfinityValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

            // Act.
            argument.IsNotPositiveInfinity();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is FloatNotPositiveInfinityValidationPredicate);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNotPositiveInfinity();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}
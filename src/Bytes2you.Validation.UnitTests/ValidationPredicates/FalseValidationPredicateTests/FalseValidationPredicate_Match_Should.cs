﻿using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.FalseValidationPredicateTests
{
    [TestClass]
    public class FalseValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsFalse()
        {
            // Arrange.
            bool value = false;

            // Act.
            IValidationPredicateResult result = FalseValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is false.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsTrue()
        {
            // Arrange.
            bool value = true;

            // Act.
            IValidationPredicateResult result = FalseValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is true.", result.Message);
        }
    }
}
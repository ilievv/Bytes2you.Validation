﻿using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
{
    internal class DoubleNotNaNValidationPredicate : ValidationPredicate<double>
    {
        private static readonly Lazy<DoubleNotNaNValidationPredicate> lazyInstance;

        static DoubleNotNaNValidationPredicate()
        {
            lazyInstance = new Lazy<DoubleNotNaNValidationPredicate>(() => new DoubleNotNaNValidationPredicate());
        }

        private DoubleNotNaNValidationPredicate()
        {
        }

        public static DoubleNotNaNValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override bool IsMatch(double value)
        {
            return !double.IsNaN(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNaNMessage, value);
        }

        protected override string GetUnmatchMessage(double value)
        {
            return ValidationPredicateMessages.NaNMessage;
        }
    }
}
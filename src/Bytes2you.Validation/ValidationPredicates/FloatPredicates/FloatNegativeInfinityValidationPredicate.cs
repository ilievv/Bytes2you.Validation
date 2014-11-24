﻿using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatNegativeInfinityValidationPredicate : SingletonValidationPredicate<FloatNegativeInfinityValidationPredicate, float>
    {
        private FloatNegativeInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return double.IsNegativeInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return ValidationPredicateMessages.NegativeInfinityMessage;
        }

        protected override string GetUnmatchMessage(float value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNegativeInfinityMessage, value);
        }
    }
}
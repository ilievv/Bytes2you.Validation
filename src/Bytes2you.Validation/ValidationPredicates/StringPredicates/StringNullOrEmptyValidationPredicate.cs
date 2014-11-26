﻿using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNullOrEmptyValidationPredicate : ValidationPredicate<string>
    {
        private static readonly Lazy<StringNullOrEmptyValidationPredicate> lazyInstance;

        static StringNullOrEmptyValidationPredicate()
        {
            lazyInstance = new Lazy<StringNullOrEmptyValidationPredicate>(() => new StringNullOrEmptyValidationPredicate());
        }

        private StringNullOrEmptyValidationPredicate()
        {
        }

        public static StringNullOrEmptyValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override string GetMatchMessage(string value)
        {
            return ValidationPredicateMessages.NullOrEmptyStringMessage;
        }

        protected override string GetUnmatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullOrEmptyStringMessage, value);
        }

        protected override bool IsMatch(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
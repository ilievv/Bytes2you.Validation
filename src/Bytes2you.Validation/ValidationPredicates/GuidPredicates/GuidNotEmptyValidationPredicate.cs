﻿using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.GuidPredicates
{
    internal class GuidNotEmptyValidationPredicate : SingletonValidationPredicate<GuidNotEmptyValidationPredicate, Guid>
    {
        private GuidNotEmptyValidationPredicate()
        {
        }

        protected override string GetMatchMessage(Guid value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotEmptyGuidMessage, value);
        }

        protected override string GetUnmatchMessage(Guid value)
        {
            return ValidationPredicateMessages.EmptyGuidMessage;
        }

        protected override bool IsMatch(Guid value)
        {
            return value != Guid.Empty;
        }
    }
}
﻿// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System.Collections;
using ISL.Providers.Notifications.Abstractions.Models.Exceptions;
using Xeptions;

namespace ISL.Providers.Notifications.Abstractions.Tests.Unit.Models.Exceptions
{
    public class SomeNotificationDependencyValidationException : Xeption, INotificationDependencyValidationException
    {
        public SomeNotificationDependencyValidationException(string message, Xeption innerException, IDictionary data)
            : base(message, innerException, data)
        { }
    }
}

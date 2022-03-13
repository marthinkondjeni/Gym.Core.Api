// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;

namespace Gym.Core.Api.Brokers.DateTimes
{
    public class DateTimeBroker: IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime() => DateTimeOffset.UtcNow;
    }
}

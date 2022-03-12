// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------
using Gym.Core.Api.Models.BankingDetails;
using Gym.Core.Api.Models.PaymentHistorys;
using Gym.Core.Api.Models.PersonalDetails;
using System;

namespace Gym.Core.Api.Models.Memberships
{
    public class Membership
    {
        public Guid Id { get; set; }
        public PersonalDetail PersonalDetail { get; set; }
        public BankingDetail BankingDetail { get; set; }
        public DateTimeOffset ConmerceDate { get; set; }
        public ContractPeriod ContractPeriod { get; set; }
        public bool TermsAnddCondition { get; set; }
        public PaymentHistory PaymentHistory { get; set; } 

    }
}

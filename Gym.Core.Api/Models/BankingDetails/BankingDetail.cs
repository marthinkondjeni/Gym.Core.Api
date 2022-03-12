// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------
using Gym.Core.Api.Models.Memberships;
using System;

namespace Gym.Core.Api.Models.BankingDetails
{
    public class BankingDetail: IAuditable
    {
        public Guid Id { get; set; }
        public string BankName { get; set; }
        public AccountType AccountType { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public Membership Membership { get; set; } 
    }
}

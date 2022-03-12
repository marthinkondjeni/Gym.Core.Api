// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Models.BankingDetails
{
    public class BankingDetail
    {
        public Guid Id { get; set; }
        public string BankName { get; set; }
        public AccountType AccountType { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; } 
    }
}

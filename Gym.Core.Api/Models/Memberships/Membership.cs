// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------
using System;
using Gym.Core.Api.Models.Attachments;
using Gym.Core.Api.Models.BankingDetails;
using Gym.Core.Api.Models.PaymentHistorys;
using Gym.Core.Api.Models.PersonalDetails;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Core.Api.Models.Memberships
{
    public class Membership: IAuditable
    {
        public Guid Id { get; set; }
        public DateTimeOffset ConmerceDate { get; set; }
        public ContractPeriod ContractPeriod { get; set; }
        public bool TermsAnddCondition { get; set; }
        public string PersonalDetailId { get; set; }
        [ForeignKey("PersonalDetailId")]
        public PersonalDetail PersonalDetail { get; set; }
        public Guid BankingDetailId { get; set; }
        [ForeignKey("BankingDetailId")]
        public BankingDetail BankingDetail { get; set; }
        public Guid PaymentHistoryId { get; set; }
        [ForeignKey("PaymentHistoryId")]
        public PaymentHistory PaymentHistory { get; set; }
        public Guid AttachmentId { get; set; } 
        [ForeignKey("AttachmentId")]
        public Attachment Attachment { get; set; } 
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

    }
}

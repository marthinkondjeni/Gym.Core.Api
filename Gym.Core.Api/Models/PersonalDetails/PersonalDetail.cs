// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------
using Gym.Core.Api.Models.Memberships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Models.PersonalDetails
{
    public class PersonalDetail: IAuditable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public string HomeTelephone { get; set; }
        public string WorkTelephone { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public string EmargencyContact { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }

        public Membership Membership { get; set; } 
    }
}

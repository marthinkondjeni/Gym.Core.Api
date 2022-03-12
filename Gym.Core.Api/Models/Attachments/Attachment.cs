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

namespace Gym.Core.Api.Models.Attachments
{
    public class Attachment
    {
        public Guid Id { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Form { get; set; }
        public byte [] IdCopy { get; set; }
        public Membership Membership { get; set; } 
    }
}

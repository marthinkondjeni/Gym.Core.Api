// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Memberships;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Services.Foundation.Memberships
{
    public interface IMembershipService
    {
        ValueTask<Membership> AddMembershipAsync(Membership membership);
        ValueTask<Membership> RetrieveMembershipByIdAsync(Guid membershipId);
        IQueryable<Membership> RetrieveAllMemberships();
        ValueTask<Membership> ModifyMembershipAsync(Membership membership);
        ValueTask<Membership> RemoveMembershipByIdAsync(Guid membershipId);
    }
}

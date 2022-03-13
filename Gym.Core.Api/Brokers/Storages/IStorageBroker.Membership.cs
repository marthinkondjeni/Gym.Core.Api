// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Memberships;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Membership> InsertMembershipAsync(Membership membership);
        IQueryable<Membership> SelectAllMemberships();
        ValueTask<Membership> SelectMembershipByIdAsync(Guid membershipId);
        ValueTask<Membership> UpdateMembershipAsync(Membership membership);
        ValueTask<Membership> DeleteMembershipAsync(Membership membership);
    }
}

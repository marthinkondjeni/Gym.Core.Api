// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Memberships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Membership> Memberships { get; set; }

        public async ValueTask<Membership> InsertMembershipAsync(Membership membership)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Membership> membershipEntityEntry = await broker.Memberships.AddAsync(entity: membership);
            await broker.SaveChangesAsync();

            return membershipEntityEntry.Entity;
        }

        public IQueryable<Membership> SelectAllMemberships() => this.Memberships;

        public async ValueTask<Membership> SelectMembershipByIdAsync(Guid membershipId)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await Memberships.FindAsync(membershipId);
        }

        public async ValueTask<Membership> UpdateMembershipAsync(Membership membership)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Membership> membershipEntityEntry = broker.Memberships.Update(entity: membership);
            await broker.SaveChangesAsync();

            return membershipEntityEntry.Entity;
        }

        public async ValueTask<Membership> DeleteMembershipAsync(Membership membership)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Membership> membershipEntityEntry = broker.Memberships.Remove(entity: membership);
            await broker.SaveChangesAsync();

            return membershipEntityEntry.Entity;
        }
    }
}

// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.PersonalDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<PersonalDetail> PersonalDetails { get; set; }

        public async ValueTask<PersonalDetail> InsertPersonalDetailAsync(PersonalDetail personalDetail)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<PersonalDetail> personalDetailEntityEntry = await broker.PersonalDetails.AddAsync(entity: personalDetail);
            await broker.SaveChangesAsync();

            return personalDetailEntityEntry.Entity;
        }

        public IQueryable<PersonalDetail> SelectAllPersonalDetails() => this.PersonalDetails;

        public async ValueTask<PersonalDetail> SelectPersonalDetailByIdAsync(Guid personalDetailId)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await PersonalDetails.FindAsync(personalDetailId);
        }

        public async ValueTask<PersonalDetail> UpdatePersonalDetailAsync(PersonalDetail personalDetail)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<PersonalDetail> personalDetailEntityEntry = broker.PersonalDetails.Update(entity: personalDetail);
            await broker.SaveChangesAsync();

            return personalDetailEntityEntry.Entity;
        }

        public async ValueTask<PersonalDetail> DeletePersonalDetailAsync(PersonalDetail personalDetail)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<PersonalDetail> personalDetailEntityEntry = broker.PersonalDetails.Remove(entity: personalDetail);
            await broker.SaveChangesAsync();

            return personalDetailEntityEntry.Entity;
        }
    }
}

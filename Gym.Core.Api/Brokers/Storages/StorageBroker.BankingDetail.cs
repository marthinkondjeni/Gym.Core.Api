// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.BankingDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<BankingDetail> BankingDetails { get; set; }

        public async ValueTask<BankingDetail> InsertBankingDetailAsync(BankingDetail bankingDetail)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<BankingDetail> bankingDetailEntityEntry = await broker.BankingDetails.AddAsync(entity: bankingDetail);
            await broker.SaveChangesAsync();

            return bankingDetailEntityEntry.Entity;
        }

        public IQueryable<BankingDetail> SelectAllBankingDetails() => this.BankingDetails;

        public async ValueTask<BankingDetail> SelectBankingDetailByIdAsync(Guid bankingDetailId)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await BankingDetails.FindAsync(bankingDetailId);
        }

        public async ValueTask<BankingDetail> UpdateBankingDetailAsync(BankingDetail bankingDetail)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<BankingDetail> bankingDetailEntityEntry = broker.BankingDetails.Update(entity: bankingDetail);
            await broker.SaveChangesAsync();

            return bankingDetailEntityEntry.Entity;
        }

        public async ValueTask<BankingDetail> DeleteBankingDetailAsync(BankingDetail bankingDetail)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<BankingDetail> bankingDetailEntityEntry = broker.BankingDetails.Remove(entity: bankingDetail);
            await broker.SaveChangesAsync();

            return bankingDetailEntityEntry.Entity;
        }
    }
}

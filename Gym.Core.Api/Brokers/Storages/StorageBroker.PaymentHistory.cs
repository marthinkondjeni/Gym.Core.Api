// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.PaymentHistorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<PaymentHistory> PaymentHistorys { get; set; }

        public async ValueTask<PaymentHistory> InsertPaymentHistoryAsync(PaymentHistory paymentHistory)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<PaymentHistory> paymentHistoryEntityEntry = await broker.PaymentHistorys.AddAsync(entity: paymentHistory);
            await broker.SaveChangesAsync();

            return paymentHistoryEntityEntry.Entity;
        }

        public IQueryable<PaymentHistory> SelectAllPaymentHistorys() => this.PaymentHistorys;

        public async ValueTask<PaymentHistory> SelectPaymentHistoryByIdAsync(Guid paymentHistoryId)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await PaymentHistorys.FindAsync(paymentHistoryId);
        }

        public async ValueTask<PaymentHistory> UpdatePaymentHistoryAsync(PaymentHistory paymentHistory)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<PaymentHistory> paymentHistoryEntityEntry = broker.PaymentHistorys.Update(entity: paymentHistory);
            await broker.SaveChangesAsync();

            return paymentHistoryEntityEntry.Entity;
        }

        public async ValueTask<PaymentHistory> DeletePaymentHistoryAsync(PaymentHistory paymentHistory)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<PaymentHistory> paymentHistoryEntityEntry = broker.PaymentHistorys.Remove(entity: paymentHistory);
            await broker.SaveChangesAsync();

            return paymentHistoryEntityEntry.Entity;
        }
    }
}

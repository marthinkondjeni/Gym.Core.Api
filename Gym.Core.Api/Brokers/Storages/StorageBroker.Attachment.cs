// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Attachments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Attachment> Attachments { get; set; }

        public async ValueTask<Attachment> InsertAttachmentAsync(Attachment attachment)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Attachment> attachmentEntityEntry = await broker.Attachments.AddAsync(entity: attachment);
            await broker.SaveChangesAsync();

            return attachmentEntityEntry.Entity;
        }

        public IQueryable<Attachment> SelectAllAttachments() => this.Attachments;

        public async ValueTask<Attachment> SelectAttachmentByIdAsync(Guid attachmentId)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await Attachments.FindAsync(attachmentId);
        }

        public async ValueTask<Attachment> UpdateAttachmentAsync(Attachment attachment)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Attachment> attachmentEntityEntry = broker.Attachments.Update(entity: attachment);
            await broker.SaveChangesAsync();

            return attachmentEntityEntry.Entity;
        }

        public async ValueTask<Attachment> DeleteAttachmentAsync(Attachment attachment)
        {
            using var broker = new StorageBroker(this.configuration);
            EntityEntry<Attachment> attachmentEntityEntry = broker.Attachments.Remove(entity: attachment);
            await broker.SaveChangesAsync();

            return attachmentEntityEntry.Entity;
        }
    }
}

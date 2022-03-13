// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Attachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Attachment> InsertAttachmentAsync(Attachment attachment);
        IQueryable<Attachment> SelectAllAttachments();
        ValueTask<Attachment> SelectAttachmentByIdAsync(Guid attachmentId);
        ValueTask<Attachment> UpdateAttachmentAsync(Attachment attachment);
        ValueTask<Attachment> DeleteAttachmentAsync(Attachment attachment);
    }
}

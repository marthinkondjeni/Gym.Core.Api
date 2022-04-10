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

namespace Gym.Core.Api.Services.Foundation.Attachments
{
    public interface IAttachmentService
    {
        ValueTask<Attachment> AddAttachmentAsync(Attachment attachment);
        IQueryable<Attachment> RetrieveAllAttachments();
        ValueTask<Attachment> RetrieveAttachmentByIdAsync(Guid attachmentId);
        ValueTask<Attachment> ModifyAttachmentAsync(Attachment attachment);
        ValueTask<Attachment> RemoveAttachmentByIdAsync(Guid attachmentId);
    }
}

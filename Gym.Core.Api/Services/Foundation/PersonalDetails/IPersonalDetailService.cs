// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using Gym.Core.Api.Models.PersonalDetails;

namespace Gym.Core.Api.Services.Foundation.PersonalDetails
{
    public interface IPersonalDetailService
    {
        ValueTask<PersonalDetail> AddPersonalDetailAsync(PersonalDetail personalDetail);
        ValueTask<PersonalDetail> RetrievePersonalDetailByIdAsync(Guid personalDetailId);
        IQueryable<PersonalDetail> RetrieveAllPersonalDetails();
        ValueTask<PersonalDetail> ModifyPersonalDetailAsync(PersonalDetail personalDetail);
        ValueTask<PersonalDetail> RemovePersonalDetailByIdAsync(Guid personalDetailId);
    }
}

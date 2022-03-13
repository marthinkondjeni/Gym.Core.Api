// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.PersonalDetails;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<PersonalDetail> InsertPersonalDetailAsync(PersonalDetail personalDetail);
        IQueryable<PersonalDetail> SelectAllPersonalDetails();
        ValueTask<PersonalDetail> SelectPersonalDetailByIdAsync(Guid personalDetailId);
        ValueTask<PersonalDetail> UpdatePersonalDetailAsync(PersonalDetail personalDetail);
        ValueTask<PersonalDetail> DeletePersonalDetailAsync(PersonalDetail personalDetail);
    }
}

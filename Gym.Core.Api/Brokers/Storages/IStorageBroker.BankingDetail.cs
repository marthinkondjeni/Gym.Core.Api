// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.BankingDetails;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<BankingDetail> InsertBankingDetailAsync(BankingDetail bankingDetail);
        IQueryable<BankingDetail> SelectAllBankingDetails();
        ValueTask<BankingDetail> SelectBankingDetailByIdAsync(Guid bankingDetailId);
        ValueTask<BankingDetail> UpdateBankingDetailAsync(BankingDetail bankingDetail);
        ValueTask<BankingDetail> DeleteBankingDetailAsync(BankingDetail bankingDetail);
    }
}

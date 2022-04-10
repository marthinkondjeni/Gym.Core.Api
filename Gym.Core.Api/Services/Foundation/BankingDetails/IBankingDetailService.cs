// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.BankingDetails;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Services.Foundation.BankingDetails
{
    public interface IBankingDetailService
    {
        ValueTask<BankingDetail> AddBankingDetailAsync(BankingDetail bankingDetail);
        IQueryable<BankingDetail> RetrieveAllBankingDetails();
        ValueTask<BankingDetail> RetrieveBankingDetailByIdAsync(Guid bankingDetailId);
        ValueTask<BankingDetail> ModifyBankingDetailAsync(BankingDetail bankingDetail);
        ValueTask<BankingDetail> RemoveBankingDetailByIdAsync(Guid bankingDetailId);
    }
}

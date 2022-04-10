// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.PaymentHistorys;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Services.Foundation.PaymentHistorys
{
    public interface IPaymentHistoryService
    {
        ValueTask<PaymentHistory> AddPaymentHistoryAsync(PaymentHistory paymentHistory);
        ValueTask<PaymentHistory> RetrievePaymentHistoryByIdAsync(Guid paymentHistoryId);
        IQueryable<PaymentHistory> RetrieveAllPaymentHistorys();
        ValueTask<PaymentHistory> ModifyPaymentHistoryAsync(PaymentHistory paymentHistory);
        ValueTask<PaymentHistory> RemovePaymentHistoryByIdAsync(Guid paymentHistoryId);
    }
}

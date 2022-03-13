// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.PaymentHistorys;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<PaymentHistory> InsertPaymentHistoryAsync(PaymentHistory paymentHistory);
        IQueryable<PaymentHistory> SelectAllPaymentHistorys();
        ValueTask<PaymentHistory> SelectPaymentHistoryByIdAsync(Guid paymentHistoryId);
        ValueTask<PaymentHistory> UpdatePaymentHistoryAsync(PaymentHistory paymentHistory);
        ValueTask<PaymentHistory> DeletePaymentHistoryAsync(PaymentHistory paymentHistory);
    }
}

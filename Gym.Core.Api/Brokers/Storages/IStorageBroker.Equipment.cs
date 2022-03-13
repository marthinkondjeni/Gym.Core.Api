// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Equipments;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Equipment> InsertEquipmentAsync(Equipment equipment);
        IQueryable<Equipment> SelectAllEquipments();
        ValueTask<Equipment> SelectEquipmentByIdAsync(Guid equipmentId);
        ValueTask<Equipment> UpdateEquipmentAsync(Equipment equipment);
        ValueTask<Equipment> DeleteEquipmentAsync(Equipment equipment);
    }
}

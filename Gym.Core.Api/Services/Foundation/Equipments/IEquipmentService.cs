// ---------------------------------------------------------------
// Copyright (c) Marthin Thomas All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Gym.Core.Api.Models.Equipments;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Core.Api.Services.Foundation.Equipments
{
    public interface IEquipmentService
    {
        ValueTask<Equipment> AddEquipmentAsync(Equipment equipment);
        ValueTask<Equipment> RetrieveEquipmentByIdAsync(Guid equipmentId);
        IQueryable<Equipment> RetrieveAllEquipments();
        ValueTask<Equipment> ModifyEquipmentAsync(Equipment equipment);
        ValueTask<Equipment> RemoveEquipmentByIdAsync(Guid equipmentId);
    }
}
